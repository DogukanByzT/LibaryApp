using AutoMapper;
using LibraryApp.Application.Dtos;
using LibraryApp.Domain.Entities;

namespace LibraryApp.Infrastructure.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // TEntity - TDto eşlemeleri
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<Author, AuthorDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
