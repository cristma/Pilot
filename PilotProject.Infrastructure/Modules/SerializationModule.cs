using Autofac;
using PilotProject.Infrastructure.Serialization;
using PilotProject.Infrastructure.Serialization.Impl;

namespace PilotProject.Infrastructure.Modules
{
    internal class SerializationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SerializationService>().As<ISerializationService>();
        }
    }
}