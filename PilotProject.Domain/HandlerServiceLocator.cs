using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Domain
{
    internal static class HandlerServiceLocator
    {
        public static IContainer Current { get; set; }
    }
}
