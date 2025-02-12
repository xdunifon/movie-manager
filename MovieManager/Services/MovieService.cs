using Microsoft.EntityFrameworkCore;
using MovieManager.Models.Dtos;
using MovieManager.Models.ViewModels.Movies;

namespace MovieManager.Services
{
    public interface IMovieService
    {
        Movie? GetMovie(int id);
        Movie[] GetMovies();
        MovieTableRowVM[] GetMovieTableVMs();

        Genre[] GetGenres();
        Genre? GetGenre(int id);
    }

    public class MovieService : BaseService, IMovieService
    {
        public Genre? GetGenre(int id)
        {
            return _context.Genres.Find(id);
        }

        public Genre[] GetGenres()
        {
            return _context.Genres.ToArray();
        }

        public Movie? GetMovie(int id)
        {
            return _context.Movies.Find(id);
        }

        public Movie[] GetMovies()
        {
            return _context.Movies
                .Where(movie => movie.Active)
                .Include(movie => movie.Genre)
                .ToArray();
        }

        public MovieTableRowVM[] GetMovieTableVMs()
        {
            Movie[] movies = GetMovies();
            return movies.Select(movie => new MovieTableRowVM()
            {
                Name = movie.Name,
                DateReleased = movie.DateReleased.ToShortDateString(),
                Description = movie.Description,
                Duration = movie.Duration,
                Genre = movie.Genre.Name
            }).ToArray();
        }
    }
}
