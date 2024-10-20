using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.mianshiBookProject.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.mianshiBookProject.EntityFrameworkCore;

public class EntityFrameworkCoremianshiBookProjectDbSchemaMigrator
    : ImianshiBookProjectDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoremianshiBookProjectDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the mianshiBookProjectDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<mianshiBookProjectDbContext>()
            .Database
            .MigrateAsync();
    }
}
