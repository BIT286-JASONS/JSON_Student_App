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
    public class TeacherController : Controller
    {
        // initilize list, database or repository will go here when thats being implemented
        private List<Teacher> list = new List<Teacher>();


        // constructor for Teacher Controller, add two teachers to the list
        public TeacherController()
        {
            list.Add(new Teacher { ID = 1, FirstName = "Bob", LastName = "Smith", Username = "mathrules", Password = "password" });
            list.Add(new Teacher { ID = 2, FirstName = "Sandra", LastName = "Klien", Username = "sandraklien", Password = "password" });

        }


        // basic get method that returns the entire list when it gets a call at /teacher/get
        [HttpGet("[action]")]
        public IEnumerable<Teacher> Get()
        {
            return list;
        }


        // get method that returns the ID of a teacher object, not sure if this is needed right now
        //[HttpGet("[action]")]
        //public int GetID(Teacher teacher)
        //{
        //    return list.Find(t => t.ID == teacher.ID).ID;
        //}

        [HttpGet("[action]")]
        public IActionResult GetByUsername(string username)
        {
            return new ObjectResult(list.Find(t => t.Username == username));
        }

        // get method that returns a teacher object if the id is known or returns notfound
        public IActionResult GetByID(int id)
        {
            Teacher item = list.Find(s => s.ID == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        // Creates a new teacher object in the list
        [HttpPost("[action]")]
        public IActionResult Create([FromBody] Teacher teacher)
        {
            if (teacher == null)
            {
                return BadRequest();
            }

            list.Add(teacher);

            return CreatedAtRoute("GetByID", new { id = teacher.ID }, teacher);
        }

        [HttpPost]
        public IActionResult Check(User user)
        {
            var checkinguser = list.FirstOrDefault((t => t.Username == user.Username));
            if (checkinguser.Password != user.Password || checkinguser == null)
            {
                return BadRequest();
            }
            return CreatedAtRoute("GetByUsername", new { username = user.Username });
        }

        // Update method to change the password of a teacher,
        // obviously unsecure as ANYONE can change the password to whatever they like

        [HttpPut("[action]")]
        public IActionResult Update(int id, [FromBody] Teacher teacher)
        {
            if (teacher == null || teacher.ID != id)
            {
                return BadRequest();
            }

            var teachercheck = list.Find(t => t.ID == id);
            if (teachercheck == null)
            {
                return NotFound();
            }

            teachercheck.Password = teacher.Password; 

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
