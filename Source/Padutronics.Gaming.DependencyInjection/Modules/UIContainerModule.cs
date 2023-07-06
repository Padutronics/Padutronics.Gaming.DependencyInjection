using Padutronics.DependencyInjection;
using Padutronics.Gaming.UI;
using Padutronics.Gaming.UI.Controls;

namespace Padutronics.Gaming.DependencyInjection.Modules;

internal sealed class UIContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<IVisualTree>().Use<VisualTree>().SingleInstance();

        containerBuilder.For<IUIFactoryBundle>().Use<UIFactoryBundle>().InstancePerDependency();

        containerBuilder.For<IControlFactory>().UseFactory();
        containerBuilder.For<Blank>().UseSelf().InstancePerDependency();
        containerBuilder.For<Button>().UseSelf().InstancePerDependency();
        containerBuilder.For(typeof(Background<,>)).UseSelf().InstancePerDependency();
    }
}