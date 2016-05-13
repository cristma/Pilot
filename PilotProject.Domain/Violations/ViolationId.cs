using PilotProject.Domain.BoilerPlate;
using System;
using System.Diagnostics.Contracts;

namespace PilotProject.Domain.Violations
{
    internal class ViolationId : ValueObject
    {
        public ViolationId(Guid value)
        {
            Contract.Assert(value != Guid.Empty, "Violation ID must be of non-default value.");
            this.Value = value;
        }

        public Guid Value { get; private set; }
        public static implicit operator Guid(ViolationId value) { return value != null ? value.Value : Guid.Empty; }
        public static implicit operator ViolationId(Guid value) { return new ViolationId(value); }
    }
}
