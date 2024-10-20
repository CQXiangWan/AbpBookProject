using Acme.mianshiBookProject.Authors;
using Acme.mianshiBookProject.Books;
using AutoMapper;

namespace Acme.mianshiBookProject;

public class mianshiBookProjectApplicationAutoMapperProfile : Profile
{
    public mianshiBookProjectApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Book, BookDto>(); //定义映射
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<Author, AuthorDto>();
        CreateMap<Author, AuthorLookupDto>();

    }
}
