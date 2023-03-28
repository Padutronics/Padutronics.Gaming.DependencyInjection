using Padutronics.DependencyInjection;
using Padutronics.Gaming.Components;
using Padutronics.Gaming.Components.Behaviors;
using Padutronics.Gaming.Components.Behaviors.Adapters;
using Padutronics.Gaming.Components.Factories;

namespace Padutronics.Gaming.DependencyInjection.Modules;

internal sealed class ComponentsContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<IBehaviorAdapterFactory>().UseFactory();

        RegisterBehavior<IAnimationBehavior, AnimationComponentFactory, AnimationBehaviorToComponentAdapter>(containerBuilder);
    }

    private void RegisterBehavior<TBehavior, TFactory, TAdapter>(IContainerBuilder containerBuilder)
        where TBehavior : IBehavior
        where TFactory : class, IComponentFactory<TBehavior>
        where TAdapter : BehaviorToComponentAdapter<TBehavior>
    {
        containerBuilder.For<IComponentSource>().Use<ComponentSource<TBehavior>>().SingleInstance();
        containerBuilder.For<IComponentFactory<TBehavior>>().Use<TFactory>().InstancePerDependency();
        containerBuilder.For<TAdapter>().UseSelf().InstancePerDependency();
    }
}