using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Infrastructure.RulesServices
{
    internal interface IEvaluationRulesService
    {
        void SetupRuleSet<T>();
        void ExecuteRuleSet<T>(T value);
    }
}
