using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public async Task<ActionResult> Get()
        {
            return Ok();
        }
    }
}