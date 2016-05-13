using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Infrastructure.Serialization
{
    internal interface ISerializationService
    {
        void Serialize<T>(T objectToSerialize, string file, string root, string rootNamespace);
        T Deserialize<T>(string file, string root, string rootNamespace);
    }
}
