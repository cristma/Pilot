using PilotProject.ApplicationServices.Violations;
using PilotProject.Domain;
using PilotProject.Domain.Segments;
using PilotProject.Domain.Segments.Events;
using PilotProject.Domain.Violations;
using PilotProject.Evaluation.Segments;
using PilotProject.Infrastructure.RulesServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.ApplicationServices.Handlers
{
    internal class EsaRadiusWasUpdatedEventHandler : IEventHandler<EsaRadiusWasUpdatedEvent>
    {
        private readonly string ruleSetFile = typeof(EsaRadiusWasUpdatedEventHandler) + ".rules";
        private readonly IViolationsService violationsService;
        private readonly IEvaluationRulesService evaluationRulesService;

        private EsaMinimumSizeEvaluation evaluation;
        private Violation violation;
        private Esa esa;

        public EsaRadiusWasUpdatedEventHandler(
            IViolationsService violationsService, 
            IEvaluationRulesService evaluationRulesService)
        {
            this.violationsService = violationsService;
            this.evaluationRulesService = evaluationRulesService;
        }

        public Radius Radius
        {
            get
            {
                if(esa != null)
                    return esa.Radius;
                return null;
            }
        }

        public EsaMinimumSizeEvaluation Evaluation
        {
            get
            {
                if (this.evaluation == null)
                    this.evaluation = new EsaMinimumSizeEvaluation(this.Radius);
                return this.evaluation;
            }
        }

        public void Handle(EsaRadiusWasUpdatedEvent @event)
        {
            // Setup
            this.esa = @event.Source;
            this.violation = this.violationsService.GetViolation("ESAS1001");

            // Execute
            this.evaluationRulesService.ExecuteRuleSet<EsaRadiusWasUpdatedEventHandler>(this);
        }

        public void AddViolation()
        {
            this.violationsService.AddViolation(this.violation);
        }
    }
}