using PilotProject.Domain.Aeronautical;
using PilotProject.Domain.BoilerPlate;
using System.Runtime.Serialization;

namespace PilotProject.Domain.Approaches
{
    [DataContract(Namespace = "OptimalConfiguration", Name = "Approach")]
    internal class Approach : Entity<ApproachId>
    {
        public Approach(
            ApproachId id, 
            PublishedName publishedName, 
            AerodromeId aerodrome, 
            RunwayId runway, 
            Criteria criteria, 
            LandingType landingType)
            : base(id)
        {
            this.Name = publishedName;
            this.Aerodrome = aerodrome;
            this.Runway = runway;
            this.Criteria = criteria;
        }

        [DataMember(Name = "PublishedName", EmitDefaultValue = true, IsRequired = true)]
        public PublishedName Name { get; private set; }

        public AerodromeId Aerodrome { get; private set; }

        public RunwayId Runway { get; private set; }

        [DataMember(Name = "Criteria", EmitDefaultValue = true, IsRequired = true)]
        public Criteria Criteria { get; private set; }

        [DataMember(Name = "LandingType", EmitDefaultValue = true, IsRequired = true)]
        public LandingType LandingType { get; private set; }
    }
}