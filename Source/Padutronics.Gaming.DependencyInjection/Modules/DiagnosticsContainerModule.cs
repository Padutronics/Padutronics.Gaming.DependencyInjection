using Padutronics.DependencyInjection;
using Padutronics.Gaming.Diagnostics.Console;

namespace Padutronics.Gaming.DependencyInjection.Modules;

internal sealed class DiagnosticsContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<ConsoleOptions>().UseSelf().SingleInstance();
    }
}