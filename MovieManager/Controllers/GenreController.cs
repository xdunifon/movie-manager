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
        public async Task<IActionResult> GetGenres()
        {
            var genres = await _genreService.GetGenres();
            if (genres == null) { return NotFound(); }

            return Ok(genres);
        }

        [HttpGet("{id}", Name = "Genre_GetGenre")]
        public async Task<IActionResult> GetGenreById(int id)
        {
            var genre = await _genreService.GetGenreById(id);
            if (genre == null) { return NotFound(); }

            return Ok(genre);
        }
        #endregion
    }
}
