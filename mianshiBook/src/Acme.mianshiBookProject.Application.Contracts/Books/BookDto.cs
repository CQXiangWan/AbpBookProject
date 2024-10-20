using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Acme.mianshiBookProject.Books
{
    public class BookDto : AuditedEntityDto<Guid>   //DTO类  //被用来将书籍数据传递到表示层.
                                                    //继承自 AuditedEntityDto<Guid>.与上面定义的 Book 实体一样具有一些审计属性.
                                                    //将书籍返回到表示层时,需要将Book实体转换为BookDto对象
    {
        public Guid AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
    }
}
