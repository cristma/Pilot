using PilotProject.Domain.Aeronautical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.ApplicationServices.Aeronautical
{
    internal interface IAeronauticalService
    {
        Aerodrome GetAerodrome(AerodromeId id);
        Runway GetRunway(RunwayId id);
    }
}
