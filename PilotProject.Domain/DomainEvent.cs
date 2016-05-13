using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Domain
{
    internal abstract class DomainEvent<T>
    {
        private readonly T source;

        protected DomainEvent(T source)
        {
            this.source = source;
        }

        public T Source { get { return this.source; } }
    }
}
