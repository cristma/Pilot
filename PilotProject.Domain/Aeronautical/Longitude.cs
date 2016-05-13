using PilotProject.Domain.BoilerPlate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Domain.Aeronautical
{
    internal class Longitude : ValueObject
    {
        public Longitude(double value)
        {
            this.Value = value;
        }

        public double Value { get; private set; }
        public static implicit operator double(Longitude value) { return value != null ? value.Value : double.NaN; }
        public static implicit operator Longitude(double value) { return new Longitude(value); }
    }
}
