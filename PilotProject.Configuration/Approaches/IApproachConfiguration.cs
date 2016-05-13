using PilotProject.Domain.Violations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Configuration.Approaches
{
    internal interface IApproachConfiguration
    {
        void LoadEvaluations(string configFile);
        Violation GetViolation(string violationName);
        IList<string> GetRequiredEvaluations();
    }
}
