using Volo.Abp.Modularity;

namespace NewABP.Demo;

public abstract class DemoApplicationTestBase<TStartupModule> : DemoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
