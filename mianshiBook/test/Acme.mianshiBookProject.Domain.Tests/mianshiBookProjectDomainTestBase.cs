using Volo.Abp.Modularity;

namespace Acme.mianshiBookProject;

/* Inherit from this class for your domain layer tests. */
public abstract class mianshiBookProjectDomainTestBase<TStartupModule> : mianshiBookProjectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
