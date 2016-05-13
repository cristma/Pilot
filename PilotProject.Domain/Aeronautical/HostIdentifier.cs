using PilotProject.Domain.BoilerPlate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Domain.Aeronautical
{
    internal class HostIdentifier : ValueObject
    {
        public HostIdentifier(string value)
        {
            this.Value = value;
        }

        public string Value { get; private set; }
        public static implicit operator string(HostIdentifier value) { return value != null ? value.Value : string.Empty; }
        public static implicit operator HostIdentifier(string value) { return new HostIdentifier(value); }
    }
}
