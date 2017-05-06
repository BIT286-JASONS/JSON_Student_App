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




        [HttpGet("[action]")]
        public IEnumerable<Student> Get()
        {
            var list = new List<Student>();
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
            return list;
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
