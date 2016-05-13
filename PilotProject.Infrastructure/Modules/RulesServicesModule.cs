using Autofac;
using PilotProject.Infrastructure.RulesServices;
using PilotProject.Infrastructure.RulesServices.Impl;

namespace PilotProject.Infrastructure.Modules
{
    internal class RulesServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EvaluationRulesService>().As<IEvaluationRulesService>();
        }
    }
}