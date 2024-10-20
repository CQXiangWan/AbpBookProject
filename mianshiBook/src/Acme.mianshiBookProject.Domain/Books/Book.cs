using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.mianshiBookProject.Books
{
    public class Book : AuditedAggregateRoot<Guid>
    //Book实体继承了AuditedAggregateRoot,AuditedAggregateRoot类在AggregateRoot类的基础上添加了一些基础审计属性
    //(例如CreationTime, CreatorId, LastModificationTime 等). ABP框架自动为你管理这些属性.Guid是Book实体的主键类型.

    {
        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
        public Guid AuthorId { get; set; }  //遵循 DDD 最佳实践 (规则: 仅通过id引用其它聚合对象)

    }
}
