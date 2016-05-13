using PilotProject.Domain.BoilerPlate;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Domain.Aeronautical
{
    internal class Declination : ValueObject
    {
        public Declination(double value)
        {
            Contract.Assert(value >= -180 && value <= 180);

            this.Value = value;
        }

        public double Value { get; private set; }
        public static implicit operator double(Declination value) { return value != null ? value.Value : double.NaN; }
        public static implicit operator Declination(double value) { return new Declination(value); }
    }
}
