using AutoMapper;
using Beca.BookInfo.API.Models;
using Beca.BookInfo.Data.Entities;

namespace Beca.BookInfo.API.MappingProfiles
{
    public class ChapterProfile : Profile
    {

        public ChapterProfile()
        {
            CreateMap<Chapter, ChapterModel>();
            CreateMap<ChapterModel, Chapter>();
        }

    }
}
