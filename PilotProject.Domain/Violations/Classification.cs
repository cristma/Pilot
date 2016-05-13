using PilotProject.Domain.BoilerPlate;
using PilotProject.Utilities.Enumerations;
using System.Diagnostics.Contracts;

namespace PilotProject.Domain.Violations
{
    internal class Classification : ValueObject
    {
        public Classification(ViolationClassificationTypes value)
        {
            Contract.Assert(value != ViolationClassificationTypes.UNDEFINED && value != ViolationClassificationTypes.SIZE_OF, "Violation classification must be a valid value.");
            this.Value = value;
        }

        public ViolationClassificationTypes Value { get; private set; }
        public static implicit operator ViolationClassificationTypes(Classification value) { return value != null ? value.Value : ViolationClassificationTypes.UNDEFINED; }
        public static implicit operator Classification(ViolationClassificationTypes value) { return new Classification(value); }
    }
}