using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Domain.Segments.Events
{
    internal class EsaRadiusWasUpdatedEvent : DomainEvent<Esa>
    {
        public EsaRadiusWasUpdatedEvent(Esa source) : base(source) { }
    }
}
