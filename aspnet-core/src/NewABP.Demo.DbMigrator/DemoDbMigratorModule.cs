using NewABP.Demo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace NewABP.Demo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DemoEntityFrameworkCoreModule),
    typeof(DemoApplicationContractsModule)
    )]
public class DemoDbMigratorModule : AbpModule
{
}
