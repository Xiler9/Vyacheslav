using Microsoft.AspNetCore.Mvc;
using Vyacheslav.Task1.Services;

namespace Vyacheslav.Task1.Controllers
{
    [Route("api")]
    [ApiController]
    public class Task1Controller : ControllerBase
    {
        private IGreetings _greetings;

        public Task1Controller(IGreetings IGreetings)
        {
            _greetings = IGreetings;
        }

        [HttpGet("task1")]
        public IActionResult Get()
        {
            return Ok(_greetings.Greet());
        }
    }
}
