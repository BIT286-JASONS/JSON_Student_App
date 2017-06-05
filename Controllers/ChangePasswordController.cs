using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JSON_Student_App.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JSON_Student_App.Controllers
{
    [Route("api/[controller]")]
    public class ChangePasswordController : Controller
    {
        private readonly json_app_dbContext _context;

        public ChangePasswordController(json_app_dbContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public IEnumerable<Scores> Get()
        {
            return _context.Users;
        }
        // GET method to return Scores with given Student ID (takes an int)
        [HttpGet("[action]")]
        public IActionResult GetByUsername(string username)
        {
            var items = _context.Users.Where(s => s.Username == username);
            if (items == null)
            {
                return NotFound();
            }
            return new ObjectResult(items.StudentPassword);
        }

        
        // Update method to change the password of a user,
        [HttpPut("[action]")]
        public IActionResult Save([FromBody] User user)
        {
            if (user == null || student.Password == null)
            {
                return BadRequest();
            }

            var userToUpdate = _context.Users.FirstOrDefault(s => s.Username == user.Username);
            if (userToUpdate == null)
            {
                return NotFound();
            }

            userToUpdate.Password = user.Password;

            return new NoContentResult();
        }
    }
}
