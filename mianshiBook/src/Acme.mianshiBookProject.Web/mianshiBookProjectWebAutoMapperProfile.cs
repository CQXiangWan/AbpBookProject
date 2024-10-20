using Acme.mianshiBookProject.Authors;
using Acme.mianshiBookProject.Books;
using AutoMapper;

namespace Acme.mianshiBookProject.Web;

public class mianshiBookProjectWebAutoMapperProfile : Profile
{
    public mianshiBookProjectWebAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();

        CreateMap<Pages.Authors.CreateModalModel.CreateAuthorViewModel,
                     CreateAuthorDto>();

        CreateMap<AuthorDto, Pages.Authors.EditModalModel.EditAuthorViewModel>();
        CreateMap<Pages.Authors.EditModalModel.EditAuthorViewModel,
                  UpdateAuthorDto>();
        CreateMap<Pages.Books.CreateModalModel.CreateBookViewModel, CreateUpdateBookDto>();
        CreateMap<BookDto, Pages.Books.EditModalModel.EditBookViewModel>();
        CreateMap<Pages.Books.EditModalModel.EditBookViewModel, CreateUpdateBookDto>();

    }
}

