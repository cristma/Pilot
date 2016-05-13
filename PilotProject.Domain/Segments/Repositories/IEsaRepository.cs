using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Domain.Segments.Repositories
{
    internal interface IEsaRepository
    {
        void Save(Esa esa);
        Esa Get(EsaId id);
    }
}
