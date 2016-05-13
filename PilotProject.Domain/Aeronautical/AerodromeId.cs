using PilotProject.Domain.BoilerPlate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Domain.Aeronautical
{
    internal class AerodromeId : ValueObject
    {
        public AerodromeId(string value)
        {
            this.Value = value;
        }

        public string Value { get; private set; }
        public static implicit operator string(AerodromeId value) { return value != null ? value.Value : string.Empty; }
        public static implicit operator AerodromeId(string value) { return new AerodromeId(value); }
    }
}
