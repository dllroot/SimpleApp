using Microsoft.AspNetCore.Mvc;
using SimpleApp.Models;
using System.Collections.Generic;

namespace SimpleApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Entity2Controller : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Entity2> Get() => new List<Entity2> { new Entity2 { Id = 1, Description = "Test Entity2" } };

        [HttpPost]
        public IActionResult Post(Entity2 entity) => Ok(entity);
    }
}
