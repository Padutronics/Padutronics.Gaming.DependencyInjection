using Padutronics.DependencyInjection;

namespace Padutronics.Gaming.DependencyInjection.Modules;

public sealed class GamingContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<Application>().UseSelf().SingleInstance();

        containerBuilder.For<Game>().UseSelf().SingleInstance();
        containerBuilder.For<IGameExiter>().Use<GameExiter>().SingleInstance();
    }
}