using PilotProject.Domain.BoilerPlate;
using PilotProject.Utilities.Units;
using System.Diagnostics.Contracts;
using System.Runtime.Serialization;

namespace PilotProject.Domain.Segments
{
    [DataContract(Namespace = "OptimalConfiguration", Name = "Radius")]
    internal class Radius : ValueObject
    {
        public Radius(NauticalMiles value)
        {
            Contract.Assert(value != null, "Correct distance (in nautical miles) must be defined for radius.");

        }

        [DataMember(Name = "Value", EmitDefaultValue = true, IsRequired = true)]
        public NauticalMiles Value { get; private set; }

        public static implicit operator Radius(NauticalMiles value) { return new Radius(value); }
        public static implicit operator NauticalMiles(Radius value) { return value != null ? value.Value : null; }
    }
}