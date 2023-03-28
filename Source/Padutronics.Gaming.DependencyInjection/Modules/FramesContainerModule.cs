using Padutronics.DependencyInjection;
using Padutronics.Gaming.Frames.Metrics;

namespace Padutronics.Gaming.DependencyInjection.Modules;

internal sealed class FramesContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<FrameMetricOptions>().UseSelf().InstancePerDependency();
    }
}