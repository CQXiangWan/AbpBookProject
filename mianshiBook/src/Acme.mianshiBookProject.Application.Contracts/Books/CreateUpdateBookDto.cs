using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.mianshiBookProject.Books
{
    public class CreateUpdateBookDto
    {
        //CreateUpdateBookDto 的DTO类
        //用于在创建或更新书籍的时候从用户界面获取图书信息.
        public Guid AuthorId { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        public BookType Type { get; set; } = BookType.Undefined;

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;

        [Required]
        public float Price { get; set; }
    }
}
