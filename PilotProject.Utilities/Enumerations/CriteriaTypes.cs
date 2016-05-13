using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Utilities.Enumerations
{
    public enum CriteriaTypes
    {
        UNDEFINED = -1, 
        ICAO = 0, 
        NATO = 1, 
        FAA_TERPS = 2, 
        AF_TERPS = 3, 
        SIZE_OF = AF_TERPS + 1
    }
}
