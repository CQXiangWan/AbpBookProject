using Acme.mianshiBookProject.Localization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
namespace Acme.mianshiBookProject.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class mianshiBookProjectController : AbpControllerBase
{
    protected mianshiBookProjectController()
    {
        LocalizationResource = typeof(mianshiBookProjectResource);
    }    
}
