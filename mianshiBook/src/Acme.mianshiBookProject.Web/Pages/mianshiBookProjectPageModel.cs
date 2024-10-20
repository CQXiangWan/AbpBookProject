using Acme.mianshiBookProject.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.mianshiBookProject.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class mianshiBookProjectPageModel : AbpPageModel
{
    protected mianshiBookProjectPageModel()
    {
        LocalizationResourceType = typeof(mianshiBookProjectResource);
    }
}
