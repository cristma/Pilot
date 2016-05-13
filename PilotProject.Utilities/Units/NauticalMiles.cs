using PilotProject.Utilities.Enumerations;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Utilities.Units
{
    [DataContract(Namespace = "UnitsOfMeasure", Name = "NauticalMiles")]
    public class NauticalMiles
    {
        public NauticalMiles(double value)
        {
            Contract.Assert(value >= 0 && value != double.NaN, "Nautical miles must be a valid value.");
            this.Value = value;
        }

        [DataMember(Name = "Value", EmitDefaultValue = true, IsRequired = true)]
        public double Value { get; private set; }
        public UnitsOfMeasurementTypes Units { get { return UnitsOfMeasurementTypes.NAUTICAL_MILES; } }

        public static implicit operator NauticalMiles(double value) { return new NauticalMiles(value); }
    }
}