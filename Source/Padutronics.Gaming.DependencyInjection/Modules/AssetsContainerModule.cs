using Padutronics.DependencyInjection;
using Padutronics.Gaming.Assets;

namespace Padutronics.Gaming.DependencyInjection.Modules;

internal sealed class AssetsContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<IAssetManager>().Use<AssetManager>().SingleInstance();
    }
}