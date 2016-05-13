using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Utilities.Enumerations
{
    public enum ViolationClassificationTypes
    {
        UNDEFINED = -1,
        NOTE = 0, 
        WARNING = 1, 
        CRITICAL = 2, 
        SIZE_OF = CRITICAL + 1
    }
}
