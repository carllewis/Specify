using Specify.Containers;
using Specify.Examples.Autofac;
using Specify.Tests.Containers;

namespace Specify.Tests.Examples
{
    public class SpecificationContext_AutofacMoqContainer_IntegrationTests : SpecificationContextIntegrationTests
    {
        protected override SpecificationContext<T> CreateSut<T>()
        {
            return new SpecificationContext<T>(new AutofacMoqContainer());
        }
    }
}