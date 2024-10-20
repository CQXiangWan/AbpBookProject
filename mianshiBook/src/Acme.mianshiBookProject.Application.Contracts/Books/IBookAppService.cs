using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.mianshiBookProject.Books
{
    public interface IBookAppService :
        ICrudAppService< //Defines CRUD methods
            BookDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateBookDto> //Used to create/update a book
    {
        //ICrudAppService定义了常见的CRUD方法:GetAsync,GetListAsync,CreateAsync,UpdateAsync和DeleteAsync，也可以进行重写自定义
        //ICrudAppService有一些变体, 可以在每个方法中使用单独的DTO(例如使用不同的DTO进行创建和更新).
        Task<ListResultDto<AuthorLookupDto>> GetAuthorLookupAsync();//UI用来获取作者列表, 填充一个下拉框. 使用这个下拉框选择图书作者.
    }
}
