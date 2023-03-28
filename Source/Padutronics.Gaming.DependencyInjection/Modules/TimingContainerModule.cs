using Padutronics.DependencyInjection;
using Padutronics.Gaming.Frames;
using Padutronics.Gaming.Timing;

namespace Padutronics.Gaming.DependencyInjection.Modules;

internal sealed class TimingContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<IGameTimeProvider, IFrameUpdatable>().Use<GameTimeProvider>().SingleInstance();
    }
}