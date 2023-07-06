using Padutronics.DependencyInjection;
using Padutronics.Gaming.UI;
using Padutronics.Gaming.UI.Controls;
using Padutronics.Gaming.UI.Panels;

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
        containerBuilder.For(typeof(Border<,>)).UseSelf().InstancePerDependency();
        containerBuilder.For(typeof(Label<,>)).UseSelf().InstancePerDependency();

        containerBuilder.For<IControlStyleFactory>().UseFactory();
        containerBuilder.For<IBlankStyle>().Use<BlankStyle>().InstancePerDependency();
        containerBuilder.For<IButtonStyle>().Use<ButtonStyle>().InstancePerDependency();
        containerBuilder.For(typeof(IBackgroundStyle<,>)).Use(typeof(BackgroundStyle<,>)).InstancePerDependency();
        containerBuilder.For(typeof(IBorderStyle<,>)).Use(typeof(BorderStyle<,>)).InstancePerDependency();
        containerBuilder.For(typeof(ILabelStyle<,>)).Use(typeof(LabelStyle<,>)).InstancePerDependency();

        containerBuilder.For<IPanelFactory>().UseFactory();
        containerBuilder.For<Grid>().UseSelf().InstancePerDependency();
        containerBuilder.For<StackPanel>().UseSelf().InstancePerDependency();

        containerBuilder.For<IPanelStyleFactory>().UseFactory();
        containerBuilder.For<IGridStyle>().Use<GridStyle>().InstancePerDependency();
        containerBuilder.For<IStackPanelStyle>().Use<StackPanelStyle>().InstancePerDependency();
    }
}