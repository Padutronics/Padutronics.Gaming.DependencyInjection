using Padutronics.DependencyInjection;
using Padutronics.Gaming.Components.Behaviors;
using Padutronics.Gaming.Diagnostics.Console;
using Padutronics.Gaming.Diagnostics.Console.Behaviors;

namespace Padutronics.Gaming.DependencyInjection.Modules;

internal sealed class DiagnosticsContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<ConsoleOptions>().UseSelf().SingleInstance();
        containerBuilder.For<IConsoleVisibilityManager, IConsoleVisibilityProvider>().Use<ConsoleVisibilityManager>().SingleInstance();

        containerBuilder.For<IInputBehavior>().Use<ConsoleInputBehavior>().SingleInstance();
    }
}