using Acme.mianshiBookProject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.mianshiBookProject.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(mianshiBookProjectEntityFrameworkCoreModule),
    typeof(mianshiBookProjectApplicationContractsModule)
    )]
public class mianshiBookProjectDbMigratorModule : AbpModule
{
}
