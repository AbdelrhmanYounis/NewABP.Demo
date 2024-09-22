using NewABP.Demo.Samples;
using Xunit;

namespace NewABP.Demo.EntityFrameworkCore.Domains;

[Collection(DemoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<DemoEntityFrameworkCoreTestModule>
{

}
