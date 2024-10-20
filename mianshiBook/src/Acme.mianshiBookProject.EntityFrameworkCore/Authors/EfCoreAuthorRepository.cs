using Acme.mianshiBookProject.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.mianshiBookProject.Authors
{
    public class EfCoreAuthorRepository
        : EfCoreRepository<mianshiBookProjectDbContext, Author, Guid>,
            IAuthorRepository
    {
        public EfCoreAuthorRepository(
            IDbContextProvider<mianshiBookProjectDbContext> dbContextProvider)
            : base(dbContextProvider)        //EfCoreAuthorRepository 的构造函数接受一个 IDbContextProvider<BookStoreDbContext>，
                                             //并将其传递给基类 EfCoreRepository。这使得仓储能够访问数据库上下文。
        {
        }

        public async Task<Author> FindByNameAsync(string name)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.FirstOrDefaultAsync(author => author.Name == name);
        }

        public async Task<List<Author>> GetListAsync(
            int skipCount,
            int maxResultCount,
            string sorting,
            string filter = null)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet
                .WhereIf(    //WhereIf 是ABP 框架的快捷扩展方法. 它仅当第一个条件满足时, 执行 Where 查询. 
                    !filter.IsNullOrWhiteSpace(),  
                    author => author.Name.Contains(filter)
                 )
                .OrderBy(sorting)
                .Skip(skipCount)
                .Take(maxResultCount)
                .ToListAsync();
        }
    }
}
