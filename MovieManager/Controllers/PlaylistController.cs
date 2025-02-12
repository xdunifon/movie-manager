using Microsoft.AspNetCore.Mvc;

namespace MovieManager.Controllers
{
    [ApiController]
    [Route("api/playlists")]
    public class PlaylistController : ControllerBase
    {
        [HttpGet("", Name = "PlaylistsIndex")]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
