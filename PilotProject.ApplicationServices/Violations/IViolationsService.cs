using PilotProject.Domain.Violations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.ApplicationServices.Violations
{
    internal interface IViolationsService
    {
        IList<Violation> GetConfiguredViolations();
        void AddViolation(Violation violation);
        Violation GetViolation(string key);
    }
}
