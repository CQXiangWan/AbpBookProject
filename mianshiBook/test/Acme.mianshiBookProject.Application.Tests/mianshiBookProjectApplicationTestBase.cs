using Volo.Abp.Modularity;

namespace Acme.mianshiBookProject;

public abstract class mianshiBookProjectApplicationTestBase<TStartupModule> : mianshiBookProjectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
