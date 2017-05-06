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
    public class ScoreController : Controller
    {






        [HttpGet("[action]")]
        public IEnumerable<Score> Get()
        {
            var list = new List<Score>();
            list.Add(new Score { ID = 1, GameID = 1, StudentID = 4, NumberQuestions = 10, NumberCorrect = 8, Time = RandomDayFunc(), TeacherID = 1 });
            list.Add(new Score { ID = 2, GameID = 3, StudentID = 1, NumberQuestions = 10, NumberCorrect = 3, Time = RandomDayFunc(), TeacherID = 1 });
            list.Add(new Score { ID = 3, GameID = 2, StudentID = 3, NumberQuestions = 10, NumberCorrect = 4, Time = RandomDayFunc(), TeacherID = 1 });
            list.Add(new Score { ID = 4, GameID = 4, StudentID = 4, NumberQuestions = 10, NumberCorrect = 9, Time = RandomDayFunc(), TeacherID = 1 });
            list.Add(new Score { ID = 5, GameID = 3, StudentID = 5, NumberQuestions = 10, NumberCorrect = 4, Time = RandomDayFunc(), TeacherID = 1 });
            list.Add(new Score { ID = 6, GameID = 1, StudentID = 1, NumberQuestions = 10, NumberCorrect = 4, Time = RandomDayFunc(), TeacherID = 1 });
            list.Add(new Score { ID = 7, GameID = 1, StudentID = 3, NumberQuestions = 10, NumberCorrect = 6, Time = RandomDayFunc(), TeacherID = 1 });
            list.Add(new Score { ID = 8, GameID = 2, StudentID = 2, NumberQuestions = 10, NumberCorrect = 3, Time = RandomDayFunc(), TeacherID = 1 });
            list.Add(new Score { ID = 9, GameID = 4, StudentID = 3, NumberQuestions = 10, NumberCorrect = 5, Time = RandomDayFunc(), TeacherID = 1 });
            list.Add(new Score { ID = 10, GameID = 5, StudentID = 5, NumberQuestions = 10, NumberCorrect = 4, Time = RandomDayFunc(), TeacherID = 1 });
            list.Add(new Score { ID = 11, GameID = 6, StudentID = 1, NumberQuestions = 10, NumberCorrect = 4, Time = RandomDayFunc(), TeacherID = 1 });
            return list;
        }

        public DateTime RandomDayFunc()
        {
            DateTime from = new DateTime(2017, 3, 1);
            DateTime to = DateTime.Now;
            var rnd = new Random();
            TimeSpan range = new TimeSpan(to.Ticks - from.Ticks);
            return from + new TimeSpan((long)(range.Ticks * rnd.NextDouble()));
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
