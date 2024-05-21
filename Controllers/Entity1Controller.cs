using Microsoft.AspNetCore.Mvc;
using SimpleApp.Models;
using System.Collections.Generic;

namespace SimpleApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Entity1Controller : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Entity1> Get() => new List<Entity1> { new Entity1 { Id = 1, Name = "Test Entity1" } };

        [HttpPost]
        public IActionResult Post(Entity1 entity) => Ok(entity);
    }
}
