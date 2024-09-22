using Volo.Abp.Modularity;

namespace NewABP.Demo;

[DependsOn(
    typeof(DemoApplicationModule),
    typeof(DemoDomainTestModule)
)]
public class DemoApplicationTestModule : AbpModule
{

}
