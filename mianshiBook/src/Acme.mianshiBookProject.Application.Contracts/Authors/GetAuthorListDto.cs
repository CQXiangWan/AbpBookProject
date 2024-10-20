using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Acme.mianshiBookProject.Authors
{
    public class GetAuthorListDto : PagedAndSortedResultRequestDto   //PagedAndSortedResultRequestDto
                                                                     //具有标准分页和排序属性: int MaxResultCount, int SkipCount 和 string Sorting.
    {
        public string? Filter { get; set; }   // 用于搜索作者. 它可以是 null (或空字符串) 以获得所有用户.
    }
}
