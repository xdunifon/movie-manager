using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieManager.Models.Database;
using MovieManager.Models.Dtos.Movie;
using MovieManager.Models.ViewModels.Movies;

namespace MovieManager.Services.DataServices
{
    public interface IMovieService : IBaseService
    {
        MovieDisplayDto? GetMovie(int id);
        MovieDisplayDto[] GetMovies();
    }

    public class MovieService : BaseService, IMovieService
    {
        private readonly IMapper _mapper;

        public MovieService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public MovieDisplayDto? GetMovie(int id)
        {
            Movie? movie = _context.Movies.Find(id);
            if (movie == null) return null;

            return _mapper.Map<MovieDisplayDto>(movie);
        }

        public MovieDisplayDto[] GetMovies()
        {
            return _context.Movies
                .Where(movie => movie.Active)
                .Include(movie => movie.Genre)
                .Select(movie => _mapper.Map<MovieDisplayDto>(movie)).ToArray();
        }
    }
}
