using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace PilotProject.Domain
{
    public static class DomainEvents
    {
        [ThreadStatic]
        private static List<Delegate> actions;
        private static List<Delegate> Actions
        {
            get
            {
                if(actions == null)
                {
                    actions = new List<Delegate>();
                }

                return actions;
            }
        }

        public static IDisposable Register<T>(Action<T> callback)
        {
            Actions.Add(callback);
            return new DomainEventRegistrationRemover(() => Actions.Remove(callback));
        }

        public static void Raise<T>(T eventArgs)
        {
            try
            {
                IEnumerable<IEventHandler<T>> registeredHandlers = HandlerServiceLocator.Current.Resolve<IEnumerable<IEventHandler<T>>>();
                foreach(IEventHandler<T> handler in registeredHandlers)
                {
                    handler.Handle(eventArgs);
                }
            }
            catch(NullReferenceException)
            {
                System.Diagnostics.Debug.WriteLine("No handler locator has been specified.");
            }

            foreach(Action action in actions)
            {
                Action<T> typedAction = action as Action<T>;
                if(typedAction != null)
                {
                    typedAction(eventArgs);
                }
            }
        }

        private sealed class DomainEventRegistrationRemover : IDisposable
        {
            private readonly Action callOnDispose;

            public DomainEventRegistrationRemover(Action toCall)
            {
                callOnDispose = toCall;
            }

            public void Dispose()
            {
                callOnDispose();
            }
        }
    }
}