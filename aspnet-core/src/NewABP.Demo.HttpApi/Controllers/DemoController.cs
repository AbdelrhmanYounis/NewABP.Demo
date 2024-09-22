using NewABP.Demo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace NewABP.Demo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DemoController : AbpControllerBase
{
    protected DemoController()
    {
        LocalizationResource = typeof(DemoResource);
    }
}
