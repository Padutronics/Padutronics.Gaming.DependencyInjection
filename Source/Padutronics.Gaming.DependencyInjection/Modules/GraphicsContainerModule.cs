using Padutronics.DependencyInjection;
using Padutronics.Gaming.Graphics;
using Padutronics.Gaming.Graphics.Resources;

namespace Padutronics.Gaming.DependencyInjection.Modules;

internal sealed class GraphicsContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<RenderViewOptions>().UseSelf().InstancePerDependency();

        containerBuilder.For<IResourceFactory>().Use<ResourceFactory>().InstancePerDependency();
    }
}