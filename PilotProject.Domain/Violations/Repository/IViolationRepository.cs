using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Domain.Violations.Repository
{
    internal interface IViolationRepository
    {
        void Save(Violation violation);
    }
}
