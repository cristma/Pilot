using PilotProject.Domain.BoilerPlate;
using PilotProject.Utilities.Enumerations;
using System.Diagnostics.Contracts;

namespace PilotProject.Domain.Approaches
{
    internal class LandingType : ValueObject
    {
        public LandingType(ApproachLandingTypes value)
        {
            Contract.Assert(value != ApproachLandingTypes.SIZE_OF && value != ApproachLandingTypes.UNDEFINED, "Approach landing type must be a valid value.");
            this.Value = value;
        }

        public ApproachLandingTypes Value { get; private set; }
        public static implicit operator ApproachLandingTypes(LandingType value) { return value != null ? value.Value : ApproachLandingTypes.UNDEFINED; }
        public static implicit operator LandingType(ApproachLandingTypes value) { return new LandingType(value); }
    }
}