using Padutronics.DependencyInjection;
using Padutronics.Gaming.Scenes;

namespace Padutronics.Gaming.DependencyInjection.Modules;

internal sealed class ScenesContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<ISceneManager, ISceneProvider>().Use<SceneManager>().SingleInstance();
    }
}