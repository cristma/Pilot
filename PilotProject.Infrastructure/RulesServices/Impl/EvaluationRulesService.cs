using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Workflow.Activities.Rules;
using System.Workflow.Activities.Rules.Design;
using System.Workflow.ComponentModel.Serialization;
using System.Xml;

namespace PilotProject.Infrastructure.RulesServices.Impl
{
    internal class EvaluationRulesService
    {
        public void SetupRuleSet<T>()
        {
            RuleSet ruleSet = null;
            string filename = typeof(T).ToString() + ".xml";
            RuleSetDialog ruleSetDialog = new RuleSetDialog(typeof(T), null, ruleSet);
            DialogResult result = ruleSetDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                WorkflowMarkupSerializer serializer = new WorkflowMarkupSerializer();
                using (XmlWriter rulesWriter = XmlWriter.Create(filename))
                {
                    serializer.Serialize(rulesWriter, ruleSetDialog.RuleSet);
                    rulesWriter.Flush();
                    rulesWriter.Close();
                }
            }
        }

        public void ExecuteRuleSet<T>(T value)
        {
            string rulesFile = typeof(T) + ".xml";
            XmlTextReader rulesReader = new XmlTextReader(rulesFile);
            WorkflowMarkupSerializer serializer = new WorkflowMarkupSerializer();
            RuleSet ruleSet = (RuleSet)serializer.Deserialize(rulesReader);
            rulesReader.Close();

            if(ruleSet != null)
            {
                RuleValidation validation = new RuleValidation(typeof(T), null);
                RuleExecution execution = new RuleExecution(validation, value);
                ruleSet.Execute(execution);
            }
        }
    }
}
