using Microsoft.AspNetCore.Mvc;
using MovieManager.Models.Dtos.Movie;
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
        public async Task<IActionResult> GetMovies()
        {
            MovieDisplayDto[]? movies = await _movieService.GetMovies();
            if (movies == null) { return NotFound(); }

            return Ok(movies);
        }

        [HttpGet("{id}", Name = "Movie_GetMovieById")]
        public async Task<IActionResult> GetMovieById(int id)
        {
            MovieDisplayDto? movie = await _movieService.GetMovie(id);
            if (movie == null) { return NotFound(); }

            return Ok(movie);
        }
        #endregion
    }
}
