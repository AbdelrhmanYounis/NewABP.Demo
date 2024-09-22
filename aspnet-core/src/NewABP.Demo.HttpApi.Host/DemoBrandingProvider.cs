using Microsoft.Extensions.Localization;
using NewABP.Demo.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace NewABP.Demo;

[Dependency(ReplaceServices = true)]
public class DemoBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<DemoResource> _localizer;

    public DemoBrandingProvider(IStringLocalizer<DemoResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
