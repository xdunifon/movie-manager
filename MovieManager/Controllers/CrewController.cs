using Microsoft.AspNetCore.Mvc;

namespace MovieManager.Controllers
{
    [ApiController]
    [Route("api/crew-members")]
    public class CrewController : ControllerBase
    {
        [HttpGet("", Name = "CrewMemberIndex")]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
