using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JSON_Student_App.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JSON_Student_App.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {

        private List<Student> list = new List<Student>();

        public StudentController()
        {
            list.Add(new Student
            {
                ID = 1,
                FirstName = "Joe",
                LastName = "Thompson",
                Username = "jthomp",
                Password = "1234",
                TeacherID = 1
            });
            list.Add(new Student
            {
                ID = 2,
                FirstName = "Kimmy",
                LastName = "Schmidt",
                Username = "kschmidt",
                Password = "1234",
                TeacherID = 1
            });
            list.Add(new Student
            {
                ID = 3,
                FirstName = "Jerome",
                LastName = "Lewis",
                Username = "jlewis",
                Password = "1234",
                TeacherID = 1
            });
            list.Add(new Student
            {
                ID = 4,
                FirstName = "Micky",
                LastName = "O'rilley",
                Username = "mickyo",
                Password = "1234",
                TeacherID = 1
            });
            list.Add(new Student
            {
                ID = 5,
                FirstName = "Sanjay",
                LastName = "Patel",
                Username = "spatel",
                Password = "1234",
                TeacherID = 1
            });
            list.Add(new Student
            {
                ID = 6,
                FirstName = "Martha",
                LastName = "Fleming",
                Username = "mfleming",
                Password = "1234",
                TeacherID = 1
            });
        }


        [HttpGet("[action]")]
        public IEnumerable<Student> Get()
        {
        
            return list;
        }

        //get method to return an object with given username
        [HttpGet("[action]")]
        public IActionResult GetByUsername(string username)
        {
            return new ObjectResult(list.Find(S => S.Username == username));
        }

        // get method that returns a teacher object if the id is known or returns notfound
        public IActionResult GetByID(int id)
        {
            Student item = list.Find(s => s.ID == id);
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
            return new ObjectResult(list.Where(s => s.TeacherID == teacherID));
        }

        // Creates a new teacher object in the list
        [HttpPost("[action]")]
        public IActionResult Create([FromBody] Student student)
        {
            if (student == null)
            {
                return BadRequest();
            }

            list.Add(student);

            return CreatedAtRoute("GetByID", new { id = student.ID }, student);
        }


        // Update method to change the password of a teacher,
        // obviously unsecure as ANYONE can change the password to whatever they like
        [HttpPut("[action]")]
        public IActionResult Update(int id, [FromBody] Student student)
        {
            if (student == null || student.ID != id)
            {
                return BadRequest();
            }

            var teachercheck = list.Find(s => s.ID == id);
            if (teachercheck == null)
            {
                return NotFound();
            }

            teachercheck.Password = student.Password;

            return new NoContentResult();
        }




        //// GET: api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
