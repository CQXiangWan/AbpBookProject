using Microsoft.Extensions.Localization;
using Acme.mianshiBookProject.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.mianshiBookProject.Web;

[Dependency(ReplaceServices = true)]
public class mianshiBookProjectBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<mianshiBookProjectResource> _localizer;

    public mianshiBookProjectBrandingProvider(IStringLocalizer<mianshiBookProjectResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
