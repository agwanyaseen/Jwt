using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechnorexNotes.Models;

namespace TechnorexNotes.Controllers
{
    [Route("api/[controller]/")]
    public class TaskController : ControllerBase
    {
        
        //Add a new Note
        [HttpPost]
        public IActionResult Post(RegisterNote registerNote)
        {
            return null;
        }

        //Get particular note by its Id
        [Authorize]
        [HttpGet("{noteId}")]
        public IActionResult Get(int noteId)
        {
            return Ok(noteId);
        }


        ////Get All the notes of a particular employee
        //[HttpGet]
        //[Route("Task/{UserId}")]
        //public IActionResult GetNotes(int userId)
        //{
        //    return null;
        //}


    }
}