using Autofac;

namespace Api.Infrastructure.CrossCutting.IOC
{
    public class ModuleIOC: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIOC.Load(builder);
        }
    }
}
