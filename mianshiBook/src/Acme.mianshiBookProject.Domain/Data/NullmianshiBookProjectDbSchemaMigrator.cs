using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.mianshiBookProject.Data;

/* This is used if database provider does't define
 * ImianshiBookProjectDbSchemaMigrator implementation.
 */
public class NullmianshiBookProjectDbSchemaMigrator : ImianshiBookProjectDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
