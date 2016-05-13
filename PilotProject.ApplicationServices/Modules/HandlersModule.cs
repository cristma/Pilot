using Autofac;
using PilotProject.ApplicationServices.Handlers;
using PilotProject.Domain;
using PilotProject.Domain.Segments.Events;

namespace PilotProject.ApplicationServices.Modules
{
    public class HandlersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EsaRadiusWasUpdatedEventHandler>().As<IEventHandler<EsaRadiusWasUpdatedEvent>>();
        }
    }
}