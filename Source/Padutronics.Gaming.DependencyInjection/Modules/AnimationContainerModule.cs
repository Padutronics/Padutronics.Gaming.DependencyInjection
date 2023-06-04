using Padutronics.DependencyInjection;
using Padutronics.Gaming.Animations;

namespace Padutronics.Gaming.DependencyInjection.Modules;

internal sealed class AnimationContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<IAnimationManager, IAnimationUpdater>().Use<AnimationManager>().SingleInstance();

        containerBuilder.For<IAnimationTemplateFactory>().UseFactory();
    }
}