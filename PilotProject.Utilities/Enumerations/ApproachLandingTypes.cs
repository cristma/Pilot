using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Utilities.Enumerations
{
    public enum ApproachLandingTypes
    {
        UNDEFINED = -1, 
        STRAIGHT_IN = 0, 
        CIRCLING_ONLY = 1, 
        SIZE_OF = CIRCLING_ONLY + 1
    }
}