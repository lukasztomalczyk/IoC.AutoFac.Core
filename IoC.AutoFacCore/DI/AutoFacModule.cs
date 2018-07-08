using Autofac;
using IoC.AutoFacCore.Services;

namespace IoC.AutoFacCore.DI
{
    public class AutoFacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DataBaseServices>()
                .As<IDataBaseServices>()
                .SingleInstance();
            //  .InstancePerLifetimeScope();
        }
    }
}