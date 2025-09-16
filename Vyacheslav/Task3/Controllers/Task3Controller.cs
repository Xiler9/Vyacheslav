using Microsoft.AspNetCore.Mvc;
using Vyacheslav.Task3.Classes;
using Vyacheslav.Task3.Services;

namespace Vyacheslav.Task3.Controllers
{
    [Route("api")]
    [ApiController]
    public class Task3Controller : ControllerBase
    {
        private INoteService _noteService;

        public Task3Controller(INoteService noteController)
        {
            _noteService = noteController;
        }

        [HttpPost("notes")]
        public IActionResult AddNote([FromBody] Request request)
        {
            return Ok(_noteService.AddNote(request.Title, request.Content));
        }

        [HttpDelete("notes")]
        public IActionResult DeleteNote(int id)
        {
            return Ok(_noteService.DeleteNote(id));
        }

        [HttpGet("notes")]
        public IActionResult GetNote(int id)
        {
            return Ok(_noteService.GetNote(id));
        }

        [HttpGet("notes/all")]
        public IActionResult GetAllNotes()
        {
            return Ok(_noteService.GetAllNotes());
        }
    }
}