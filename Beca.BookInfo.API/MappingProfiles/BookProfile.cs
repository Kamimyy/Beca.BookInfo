using AutoMapper;
using Beca.BookInfo.API.Models;
using Beca.BookInfo.Data.Entities;

namespace Beca.BookInfo.API.MappingProfiles
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<Book, BookModel>();
            CreateMap<BookModel, Book>();
        }
    }
}

