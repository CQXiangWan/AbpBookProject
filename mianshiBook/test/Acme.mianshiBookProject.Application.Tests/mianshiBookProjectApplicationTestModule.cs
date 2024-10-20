using Volo.Abp.Modularity;

namespace Acme.mianshiBookProject;

[DependsOn(
    typeof(mianshiBookProjectApplicationModule),
    typeof(mianshiBookProjectDomainTestModule)
)]
public class mianshiBookProjectApplicationTestModule : AbpModule
{

}
