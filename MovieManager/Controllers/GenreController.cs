using Microsoft.AspNetCore.Mvc;
using MovieManager.Services.DataServices;

namespace MovieManager.Controllers
{
    [ApiController]
    [Route("api/genres")]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService _genreService;

        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        #region GET
        [HttpGet("", Name = "Genre_GetGenres")]
        public IActionResult GetGenres()
        {
            var genres = _genreService.GetGenres();
            if (genres == null || genres.Length == 0)
            {
                return NotFound();
            }

            return Ok(genres);
        }

        [HttpGet("{id}", Name = "Genre_GetGenre")]
        public IActionResult GetGenreById(int id)
        {
            var genre = _genreService.GetGenreById(id);
            if (genre == null) { return NotFound(); }

            return Ok(genre);
        }
        #endregion
    }
}
