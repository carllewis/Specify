using Autofac;
using Autofac.Features.ResolveAnything;
using Specify.Containers;
using Specify.Containers.Mocking;

namespace Specify.Examples.Autofac
{
    /// <summary>
    /// Automocking container that uses Moq to create mocks and Autofac as the container. 
    /// </summary>
    public class AutofacMoqContainer : IocContainer
    {
        public AutofacMoqContainer()
            : base(CreateBuilder())
        {
        }

        static ContainerBuilder CreateBuilder()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterSource(new AnyConcreteTypeNotAlreadyRegisteredSource());
            containerBuilder.RegisterSource(new AutofacMockRegistrationHandler(new MoqMockFactory()));
            return containerBuilder;
        }
    }
}