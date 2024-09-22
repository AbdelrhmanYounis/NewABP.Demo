using Xunit;

namespace NewABP.Demo.EntityFrameworkCore;

[CollectionDefinition(DemoTestConsts.CollectionDefinitionName)]
public class DemoEntityFrameworkCoreCollection : ICollectionFixture<DemoEntityFrameworkCoreFixture>
{

}
