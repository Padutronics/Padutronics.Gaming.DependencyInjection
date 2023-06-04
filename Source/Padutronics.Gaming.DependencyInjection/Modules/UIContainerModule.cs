using Padutronics.DependencyInjection;
using Padutronics.Gaming.UI;

namespace Padutronics.Gaming.DependencyInjection.Modules;

internal sealed class UIContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<ILayoutServices>().Use<LayoutServices>().SingleInstance();
    }
}