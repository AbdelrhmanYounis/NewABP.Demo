using NewABP.Demo.Samples;
using Xunit;

namespace NewABP.Demo.EntityFrameworkCore.Applications;

[Collection(DemoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<DemoEntityFrameworkCoreTestModule>
{

}
