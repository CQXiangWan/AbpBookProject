using Volo.Abp.Modularity;

namespace Acme.mianshiBookProject;

[DependsOn(
    typeof(mianshiBookProjectDomainModule),
    typeof(mianshiBookProjectTestBaseModule)
)]
public class mianshiBookProjectDomainTestModule : AbpModule
{

}
