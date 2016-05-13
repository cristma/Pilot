using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PilotProject.Infrastructure.RulesServices.Impl;
using PilotProject.Domain.Segments;
using PilotProject.ApplicationServices.Handlers;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            EvaluationRulesService service = new EvaluationRulesService();
            service.SetupRuleSet<EsaRadiusWasUpdatedEventHandler>();
        }
    }
}
