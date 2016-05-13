using PilotProject.Domain.BoilerPlate;
using System;
using System.Diagnostics.Contracts;

namespace PilotProject.Domain.Segments
{
    internal class EsaId : ValueObject
    {
        public EsaId(Guid value)
        {
            Contract.Assert(value != Guid.Empty, "GUID must be properly defined.");
        }

        public Guid Value { get; private set; }

        public static implicit operator Guid(EsaId value) { return value != null ? value.Value : Guid.Empty; }
        public static implicit operator EsaId(Guid value) { return new EsaId(value); }
    }
}