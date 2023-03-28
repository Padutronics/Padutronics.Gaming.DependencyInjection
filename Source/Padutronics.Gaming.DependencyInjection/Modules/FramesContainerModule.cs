using Padutronics.DependencyInjection;
using Padutronics.Gaming.Frames.Metrics;
using Padutronics.Gaming.Frames.Metrics.Measurers;
using Padutronics.Gaming.Frames.Runners;

namespace Padutronics.Gaming.DependencyInjection.Modules;

internal sealed class FramesContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<FrameMetricOptions>().UseSelf().InstancePerDependency();
        containerBuilder.For<IFrameMetricManager>().Use<FrameMetricManager>().SingleInstance();

        containerBuilder.For<IFrameMeasurer, IFrameCountProvider>().Use<FrameCountMeasurer>().SingleInstance();
        containerBuilder.For<IFrameMeasurer, IFrameTimeProvider>().Use<FrameTimeMeasurer>().SingleInstance();

        RegisterFrameRunner<AnimationFrameRunner>(containerBuilder);
        RegisterFrameRunner<BeginDrawFrameRunner>(containerBuilder);
        RegisterFrameRunner<DrawComponentFrameRunner>(containerBuilder);
        RegisterFrameRunner<EndDrawFrameRunner>(containerBuilder);
        RegisterFrameRunner<InputQueueFrameRunner>(containerBuilder);
        RegisterFrameRunner<SwitchSceneFrameRunner>(containerBuilder);
        RegisterFrameRunner<UpdatableFrameRunner>(containerBuilder);
    }

    private void RegisterFrameRunner<TFrameRunner>(IContainerBuilder containerBuilder)
        where TFrameRunner : class, IFrameRunner
    {
        containerBuilder.For<IFrameRunner>().Use<TFrameRunner>().SingleInstance();
    }
}