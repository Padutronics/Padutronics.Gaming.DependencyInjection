using Padutronics.DependencyInjection;
using Padutronics.Gaming.Frames.Metrics;
using Padutronics.Gaming.Frames.Metrics.Measurers;

namespace Padutronics.Gaming.DependencyInjection.Modules;

internal sealed class FramesContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<FrameMetricOptions>().UseSelf().InstancePerDependency();
        containerBuilder.For<IFrameMetricManager>().Use<FrameMetricManager>().SingleInstance();

        containerBuilder.For<IFrameMeasurer, IFrameCountProvider>().Use<FrameCountMeasurer>().SingleInstance();
    }
}