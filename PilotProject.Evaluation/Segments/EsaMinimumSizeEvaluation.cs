using PilotProject.Domain.Segments;
using System;

namespace PilotProject.Evaluation.Segments
{
    internal class EsaMinimumSizeEvaluation
    {
        private readonly Radius radius;

        public EsaMinimumSizeEvaluation(
            Radius radius)
        {
            if(radius == null)
            {
                throw new ArgumentNullException();
            }

            this.radius = radius;
        }

        public bool Evaluate()
        {
            return !(this.radius.Value.Value < 1.0);
        }
    }
}