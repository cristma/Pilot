using PilotProject.Domain.Aeronautical;
using PilotProject.Domain.Approaches;
using PilotProject.Domain.BoilerPlate;
using PilotProject.Domain.Segments.Events;
using System.Runtime.Serialization;

namespace PilotProject.Domain.Segments
{
    [DataContract(Namespace = "OptimalConfiguration", Name = "Esa")]
    internal class Esa : Entity<EsaId>
    {
        private Radius radius;

        public Esa(
            EsaId id, 
            ApproachId approach, 
            Radius radius, 
            LocationId centerPoint)
            : base(id)
        {
            this.Radius = radius;
            this.Approach = approach;
            this.CenterPoint = centerPoint;
        }

        public Esa(Radius radius)
        {
            this.Radius = radius;
        }

        [DataMember(Name = "Radius", EmitDefaultValue = true, IsRequired = true)]
        public Radius Radius 
        {
            get { return this.radius; }
            private set
            {
                this.radius = value;
                DomainEvents.Raise(new EsaRadiusWasUpdatedEvent(this));
            }
        }

        public ApproachId Approach { get; private set; }
        public LocationId CenterPoint { get; private set; }
    }
}