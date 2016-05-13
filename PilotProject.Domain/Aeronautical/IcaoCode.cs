using PilotProject.Domain.BoilerPlate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Domain.Aeronautical
{
    internal class IcaoCode : ValueObject
    {
        public IcaoCode(string value)
        {
            this.Value = value;
        }

        public string Value { get; private set; }
        public static implicit operator string(IcaoCode value) { return value != null ? value.Value : string.Empty; }
        public static implicit operator IcaoCode(string value) { return new IcaoCode(value); }
    }
}
