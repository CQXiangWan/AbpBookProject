using System;
using System.Collections.Generic;
using System.Text;
using Acme.mianshiBookProject.Localization;
using Volo.Abp.Application.Services;

namespace Acme.mianshiBookProject;

/* Inherit your application services from this class.
 */
public abstract class mianshiBookProjectAppService : ApplicationService
{
    protected mianshiBookProjectAppService()
    {
        LocalizationResource = typeof(mianshiBookProjectResource);
    }
}
