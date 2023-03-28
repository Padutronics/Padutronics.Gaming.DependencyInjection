using Padutronics.DependencyInjection;
using Padutronics.Gaming.Bootstrapping;

namespace Padutronics.Gaming.DependencyInjection.Modules;

internal sealed class BootstrappingContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        RegisterBootstrapper<StartSceneBootstrapper>(containerBuilder);
    }

    private void RegisterBootstrapper<TBootstrapper>(IContainerBuilder containerBuilder)
        where TBootstrapper : class, IBootstrapper
    {
        containerBuilder.For<IBootstrapper>().Use<TBootstrapper>().SingleInstance();
    }
}