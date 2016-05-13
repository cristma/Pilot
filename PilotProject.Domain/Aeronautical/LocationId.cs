using PilotProject.Domain.BoilerPlate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Domain.Aeronautical
{
    internal class LocationId : ValueObject
    {
        public LocationId(string value)
        {
            this.Value = value;
        }

        public string Value { get; private set; }
        public static implicit operator string(LocationId value) { return value != null ? value.Value : string.Empty; }
        public static implicit operator LocationId(string value) { return new LocationId(value); }
    }
}
