using PilotProject.Domain.Violations;
using PilotProject.Utilities.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace PilotProject.Configuration.Approaches.Impl
{
    internal class ApproachConfiguration : IApproachConfiguration
    {
        private readonly IDictionary<string, Violation> violationsTable;

        public ApproachConfiguration()
        {
            this.violationsTable = new Dictionary<string, Violation>();
        }

        public void LoadEvaluations(string configFile)
        {
            XDocument document = XDocument.Load(configFile);

            IList<XElement> evaluations = (from evaluation in document.Descendants() where evaluation.Name.LocalName == "Evaluation" select evaluation).ToList();

            foreach (XElement evaluation in evaluations)
            {
                XAttribute evaluationName = (from attributeNode in evaluation.Attributes() where attributeNode.Name.LocalName == "Name" select attributeNode).SingleOrDefault();

                if (evaluationName != null)
                {
                    XElement violation = (from violationNode in evaluation.Descendants() where violationNode.Name.LocalName == "Violation" select violationNode).SingleOrDefault();

                    if (violation != null)
                    {
                        XAttribute violationType = (from type in violation.Attributes() where type.Name.LocalName == "Type" select type).SingleOrDefault();
                        XAttribute violationMessage = (from message in violation.Attributes() where message.Name.LocalName == "Message" select message).SingleOrDefault();

                        if (violationType != null && violationMessage != null)
                        {
                            ViolationClassificationTypes violationTypeEnum;
                            if (Enum.TryParse<ViolationClassificationTypes>(violationType.Value, out violationTypeEnum))
                            {
                                Violation result = new Violation(Guid.NewGuid(), violationTypeEnum, violationMessage.Value);
                                this.violationsTable.Add(evaluationName.Value, result);
                            }
                        }
                    }
                }
            }
        }
        
        public Violation GetViolation(string violationName)
        {
            Violation violation;
            this.violationsTable.TryGetValue(violationName, out violation);

            return violation;
        }

        public IList<string> GetRequiredEvaluations()
        {
            return this.violationsTable.Keys.ToList();
        }
    }
}