using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Identity_Jwt_Rolebase_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyyController : ControllerBase
    {
        [HttpGet("Admin policy")]
        [Authorize(Policy ="Admin")]
        public IActionResult admin()
        {
            return Ok("this is admin");
        }

        [HttpGet("user policy")]
        [Authorize(Policy = "User")]
        public IActionResult user()
        {
            return Ok("this is user");
        }
    }
}
