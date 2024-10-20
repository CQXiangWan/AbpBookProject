using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp;

namespace Acme.mianshiBookProject.Authors
{
    public class Author : FullAuditedAggregateRoot<Guid>,ISoftDelete
    {
        //ISoftDelete 定义了 IsDeleted 属性. 当你使用仓储删除一条记录时, ABP会自动将 IsDeleted 设置为true,
        //并将删除操作替换为修改操作(如果需要,也可以手动将 IsDeleted 设置为true). 在查询数据库时会自动过滤软删除的实体.
        public string Name { get; private set; }
        public DateTime BirthDate { get; set; }
        public string ShortBio { get; set; }


        ////软删除标志
        public bool IsDeleted { get; set; } //Defined by ISoftDelete

        private Author()
        {
            /* This constructor is for deserialization / ORM purpose */
        }

        internal Author(
            Guid id,
            [NotNull] string name,
            DateTime birthDate,
            [CanBeNull] string shortBio = null)
            : base(id)
        {
            SetName(name);
            BirthDate = birthDate;
            ShortBio = shortBio;
        }

        internal Author ChangeName([NotNull] string name)
        {
            SetName(name);
            return this;
        }

        private void SetName([NotNull] string name)
        {
            Name = Check.NotNullOrWhiteSpace(
                name,
                nameof(name),
                maxLength: AuthorConsts.MaxNameLength
            );
        }
    }
}
