using AutoMapper;
using MovieManager.Models.Database;
using MovieManager.Models.Dtos.Movie;

namespace MovieManager.Utils.AutoMapper.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, MovieDto>().ReverseMap();
            CreateMap<Movie, MovieDisplayDto>()
                .ForMember(dto => dto.DateReleased, x => x.MapFrom(movie => movie.DateReleased.ToLocalTime().ToShortDateString()))
                .ForMember(dto => dto.Genre, x => x.MapFrom(movie => movie.Genre.Name));
        }
    }
}
