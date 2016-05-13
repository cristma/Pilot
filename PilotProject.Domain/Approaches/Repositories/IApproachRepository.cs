using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Domain.Approaches.Repositories
{
    internal interface IApproachRepository
    {
        Approach Get(ApproachId id);
        void Save(Approach approach);
    }
}
