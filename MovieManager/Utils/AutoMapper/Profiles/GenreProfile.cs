using AutoMapper;
using MovieManager.Models.Database;
using MovieManager.Models.Dtos.Genre;

namespace MovieManager.Utils.AutoMapper.Profiles
{
    public class GenreProfile : Profile
    {
        public GenreProfile()
        {
            CreateMap<Genre, GenreDto>().ReverseMap();
        }
    }
}
