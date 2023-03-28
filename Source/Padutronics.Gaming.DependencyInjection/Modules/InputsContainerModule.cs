using Padutronics.DependencyInjection;
using Padutronics.Gaming.Frames;
using Padutronics.Gaming.Inputs;

namespace Padutronics.Gaming.DependencyInjection.Modules;

internal sealed class InputsContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<Input>().UseSelf().InstancePerDependency();
        containerBuilder.For<IInputProvider>().Use<InputProvider>().SingleInstance();
        containerBuilder.For<IInputQueue, IInputQueueManager>().Use<InputQueue>().SingleInstance();

        containerBuilder.For<IFrameUpdatable>().Use<InputDeviceUpdatable>().SingleInstance();
    }
}