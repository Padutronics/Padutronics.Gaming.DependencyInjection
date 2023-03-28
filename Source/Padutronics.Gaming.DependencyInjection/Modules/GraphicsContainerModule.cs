using Padutronics.DependencyInjection;
using Padutronics.Gaming.Graphics;

namespace Padutronics.Gaming.DependencyInjection.Modules;

internal sealed class GraphicsContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<RenderViewOptions>().UseSelf().InstancePerDependency();
    }
}