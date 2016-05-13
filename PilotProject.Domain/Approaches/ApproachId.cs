using PilotProject.Domain.BoilerPlate;
using System;
using System.Diagnostics.Contracts;

namespace PilotProject.Domain.Approaches
{
    internal class ApproachId : ValueObject
    {
        public ApproachId(Guid value)
        {
            Contract.Assert(value != Guid.Empty);
            this.Value = value;
        }

        public Guid Value { get; private set; }
        public static implicit operator Guid(ApproachId value) { return value != null ? value.Value : Guid.Empty; }
        public static implicit operator ApproachId(Guid value) { return new ApproachId(value); }
    }
}