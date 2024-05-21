using Microsoft.AspNetCore.Mvc;

namespace SimpleApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CheckController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("OK");
    }
}
