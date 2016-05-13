using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Utilities.Enumerations
{
    public enum UnitsOfMeasurementTypes
    {
        UNDEFINED = -1, 
        FEET = 0, 
        METERS = 1, 
        KILOMETERS = 2, 
        STATUTE_MILES = 3, 
        NAUTICAL_MILES = 4, 
        SIZE_OF = NAUTICAL_MILES + 1
    }
}
