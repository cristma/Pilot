using PilotProject.Domain.BoilerPlate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Domain.Aeronautical
{
    internal class RunwayIdentifier : ValueObject
    {
        public RunwayIdentifier(string value)
        {
            this.Value = value;
        }

        public string Value { get; private set; }
        public static implicit operator string(RunwayIdentifier value) { return value != null ? value.Value : string.Empty; }
        public static implicit operator RunwayIdentifier(string value) { return new RunwayIdentifier(value); }
    }
}