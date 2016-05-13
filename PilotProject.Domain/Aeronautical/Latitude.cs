using PilotProject.Domain.BoilerPlate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Domain.Aeronautical
{
    internal class Latitude : ValueObject
    {
        public Latitude(double value)
        {
            this.Value = value;
        }

        public double Value { get; private set; }
        public static implicit operator double(Latitude value) { return value != null ? value.Value : double.NaN; }
        public static implicit operator Latitude(double value) { return new Latitude(value); }
    }
}
