using Microsoft.AspNetCore.Mvc;
using Vyacheslav.Task2.Services;

namespace Vyacheslav.Task2.Controllers
{
    [Route("api")]
    [ApiController]
    public class Task2Controller : ControllerBase
    {
        private ITreker _treker;

        public Task2Controller(ITreker treker)
        {
            _treker = treker;
        }

        [HttpGet("visit")]
        public IActionResult Add()
        {
            return Ok(_treker.AddVisiting());
        }
        [HttpGet("visit/count")]
        public IActionResult GetCount()
        {
            return Ok(_treker.ReturnCount());
        }
    }
}
