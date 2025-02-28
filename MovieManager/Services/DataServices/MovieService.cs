using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieManager.Models.Database;
using MovieManager.Models.Dtos.Movie;
using MovieManager.Models.ViewModels.Movies;

namespace MovieManager.Services.DataServices
{
    public interface IMovieService : IBaseService
    {
        Task<MovieDisplayDto?> GetMovie(int id);
        Task<MovieDisplayDto[]> GetMovies();
    }

    public class MovieService : BaseService, IMovieService
    {
        private readonly IMapper _mapper;

        public MovieService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<MovieDisplayDto?> GetMovie(int id)
        {
            Movie? movie = await _context.Movies.FindAsync(id);
            if (movie == null) return null;

            return _mapper.Map<MovieDisplayDto>(movie);
        }

        public async Task<MovieDisplayDto[]> GetMovies()
        {
            return await _context.Movies
                .Where(movie => movie.Active)
                .Include(movie => movie.Genre)
                .Select(movie => _mapper.Map<MovieDisplayDto>(movie)).ToArrayAsync();
        }
    }
}
