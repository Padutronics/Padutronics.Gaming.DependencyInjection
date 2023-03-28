using Padutronics.DependencyInjection;
using Padutronics.Gaming.Components.Behaviors.Adapters;

namespace Padutronics.Gaming.DependencyInjection.Modules;

internal sealed class ComponentsContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<IBehaviorAdapterFactory>().UseFactory();
    }
}