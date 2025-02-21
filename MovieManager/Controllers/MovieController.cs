using Microsoft.AspNetCore.Mvc;
using MovieManager.Services.DataServices;

namespace MovieManager.Controllers
{
    [ApiController]
    [Route("api/movies")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        #region GET
        [HttpGet("", Name = "Movie_GetMovies")]
        public IActionResult GetMovies()
        {
            var movies = _movieService.GetMovies();
            if (movies == null || movies.Length == 0)
            {
                return NotFound();
            }

            return Ok(movies);
        }

        [HttpGet("{id}", Name = "Movie_GetMovieById")]
        public IActionResult GetMovieById(int id)
        {
            var movie = _movieService.GetMovie(id);
            if (movie == null) { return NotFound(); }

            return Ok(movie);
        }
        #endregion
    }
}
