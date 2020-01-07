using System;
using Microsoft.AspNetCore.Mvc;
using TechnorexNotes.Shared;
namespace TechnorexNotes.Controllers
{
    [Route("api/[controller]/")]
    public class UserController : ControllerBase
    {

        [Route("Details/{userId}")]
        [HttpGet]
        public IActionResult GetUserDetails(int userId,[FromForm]string username, [FromForm]string password)
        {
            UserDetails user = new UserDetails(username, password);

            

            Console.WriteLine("UserId = "+userId+"\nUsername = " + username + "\nPassword = " + password);

            string result = user.ValidateUser();

            if(String.IsNullOrEmpty(result))
            {
                return BadRequest("User Doesnot exist");
            }

            return Ok(user.ValidateUser());
        }
    }
}