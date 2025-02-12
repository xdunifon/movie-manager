using Microsoft.AspNetCore.Mvc;
using MovieManager.Services;

namespace MovieManager.Controllers
{
    [ApiController]
    [Route("api/movies")]
    public class MovieController : ControllerBase
    {
        private IMovieService _movieService;

        public MovieController()
        {
            _movieService = new MovieService();
        }

        [HttpGet("", Name = "MoviesIndex")]
        public IActionResult MoviesIndex()
        {
            var movies = _movieService.GetMovies();
            if (movies == null || movies.Length == 0)
            {
                return NotFound();
            }

            return Ok(movies);
        }

        [HttpGet("table")]
        public IActionResult MoviesTable()
        {
            var movies = _movieService.GetMovieTableVMs();
            if (movies == null || movies.Length == 0)
            {
                return NotFound();
            }

            return Ok(movies);
        }


        [HttpGet("{id}", Name = "GetMovieById")]
        public IActionResult GetMovieById(int id)
        {
            return Ok(_movieService.GetMovie(id));
        }

        [HttpGet("genres")]
        public IActionResult GetGenres()
        {
            var genres = _movieService.GetGenres();
            if (genres == null || genres.Length == 0)
            {
                return NotFound();
            }
            return Ok(genres);
        }

        [HttpGet("genres/{id}")]
        public IActionResult GetGenreById(int id)
        {
            return Ok(_movieService.GetGenre(id));
        }
    }
}
