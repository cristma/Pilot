using PilotProject.Domain.BoilerPlate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Domain.Aeronautical
{
    internal class RunwayId : ValueObject
    {
        public RunwayId(string value)
        {
            this.Value = value;
        }

        public string Value { get; private set; }
        public static implicit operator string(RunwayId value) { return value != null ? value.Value : string.Empty; }
        public static implicit operator RunwayId(string value) { return new RunwayId(value); }
    }
}
