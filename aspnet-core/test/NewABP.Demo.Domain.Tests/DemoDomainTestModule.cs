using Volo.Abp.Modularity;

namespace NewABP.Demo;

[DependsOn(
    typeof(DemoDomainModule),
    typeof(DemoTestBaseModule)
)]
public class DemoDomainTestModule : AbpModule
{

}
