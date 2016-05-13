using PilotProject.Domain.BoilerPlate;
using System.Diagnostics.Contracts;

namespace PilotProject.Domain.Violations
{
    internal class Violation : Entity<ViolationId>
    {
        public Violation(
            ViolationId id, 
            Classification classification, 
            Explaination explaination)
            : base(id)
        {
            Contract.Assert(classification != null && explaination != null, "Violation required classification and explaination.");

            this.Classification = classification;
            this.Explaination = explaination;
        }

        public Classification Classification { get; private set; }
        public Explaination Explaination { get; private set; }
    }
}