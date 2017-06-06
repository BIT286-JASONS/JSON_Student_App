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
    public class StudentsController : Controller
    {
        private readonly json_app_dbContext _context;

        public StudentsController(json_app_dbContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public IEnumerable<string> Pics()
        {
            return _context.Students.Select(i => i.StudentImage);
        }

        [HttpGet("[action]")]
        public IEnumerable<Students> Get()
        {

            return _context.Students;
        }

        //get method to return an object with given username
        [HttpGet("[action]")]
        public IActionResult GetByUsername(string username)
        {
            return new ObjectResult(_context.Students.FirstOrDefault(s => s.Username == username));
        }

        // get method that returns a teacher object if the id is known or returns notfound
        public IActionResult GetByID(int id)
        {
            Students item = _context.Students.FirstOrDefault(s => s.StudentId == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        //get method to return an object with given username
        [HttpGet("[action]")]
        public IActionResult GetByTeacherID(int teacherID)
        {
            return new ObjectResult(_context.Students.Where(s => s.TeacherId == teacherID));
        }

        // Creates a new teacher object in the list
        [HttpPost("[action]")]
        public IActionResult Create([FromBody] Students student)
        {
            if (student == null)
            {
                return BadRequest();
            }

            _context.Students.Add(student);

            return CreatedAtRoute("GetByID", new { id = student.StudentId }, student);
        }


        // Update method to change the password of a teacher,
        // obviously unsecure as ANYONE can change the password to whatever they like
        [HttpPut("[action]")]
        public IActionResult Update(int id, [FromBody] Students student)
        {
            if (student == null || student.StudentId != id)
            {
                return BadRequest();
            }

            var studentcheck = _context.Students.FirstOrDefault(s => s.StudentId == id);
            if (studentcheck == null)
            {
                return NotFound();
            }

            studentcheck.StudentPassword = student.StudentPassword;

            return new NoContentResult();
        }
    }
}