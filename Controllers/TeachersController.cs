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
    public class TeachersController : Controller
    {
        private readonly json_app_dbContext _context;

        public TeachersController(json_app_dbContext context)
        {
            _context = context;
        }

        // basic get method that returns the entire _context.Teachers when it gets a call at /teacher/get
        [HttpGet("[action]")]
        public IEnumerable<Teachers> Get()
        {
            return _context.Teachers;
        }


        // get method that returns the ID of a teacher object, not sure if this is needed right now
        //[HttpGet("[action]")]
        //public int GetID(Teacher teacher)
        //{
        //    return _context.Teachers.FirstOrDefault(t => t.ID == teacher.ID).ID;
        //}



        //get method to return an object with given username
        [HttpGet("[action]")]
        public IActionResult GetByUsername(string username)
        {
            return new ObjectResult(_context.Teachers.FirstOrDefault(t => t.Username == username));
        }

        // get method that returns a teacher object if the id is known or returns notfound
        public IActionResult GetByID(int id)
        {
            Teachers item = _context.Teachers.FirstOrDefault(t => t.TeacherId == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        // Creates a new teacher object in the _context.Teachers
        [HttpPost("[action]")]
        public IActionResult Create([FromBody] Teachers teacher)
        {
            if (teacher == null)
            {
                return BadRequest();
            }

            _context.Teachers.Add(teacher);

            return CreatedAtRoute("GetByID", new { id = teacher.TeacherId }, teacher);
        }

        [HttpPost("[action]")]
        public IActionResult Login(User user)
        {
            var checkinguser = _context.Teachers.FirstOrDefault((t => t.Username == user.Username));
            if (checkinguser.TeacherPassword != user.Password || checkinguser == null)
            {
                return BadRequest();
            }
            return CreatedAtRoute("GetByUsername", new { username = user.Username });
        }

        // Update method to change the password of a teacher,
        // obviously unsecure as ANYONE can change the password to whatever they like

        [HttpPut("[action]")]
        public IActionResult Update(int id, [FromBody] Teachers teacher)
        {
            if (teacher == null || teacher.TeacherId != id)
            {
                return BadRequest();
            }

            var teachercheck = _context.Teachers.FirstOrDefault(t => t.TeacherId == id);
            if (teachercheck == null)
            {
                return NotFound();
            }

            teachercheck.TeacherPassword = teacher.TeacherPassword;

            return new NoContentResult();
        }
    }
}