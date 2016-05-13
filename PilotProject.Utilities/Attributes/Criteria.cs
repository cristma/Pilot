using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Utilities.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    internal class Criteria : Attribute
    {
        private readonly string exposedName;

        public Criteria(string exposedName)
        {
            this.exposedName = exposedName;
        }

        public string ExposedName { get { return exposedName; } }
        public string Version { get; set; }
    }
}
