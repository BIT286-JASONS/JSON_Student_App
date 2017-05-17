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
        // Initializes the List, this is where database initialization will go.
        private List<Score> list = new List<Score>();
        // Initializes Random Variable for Date.
        private Random rnd = new Random();
        // Initializing Date, Month and Year for Random Day Function 
        private const int date = 1;
        private const int month = 3;
        private const int year = 2017;
        // This is a constructor for the Controller, right now it initializes the List
        // Upon Databe Creation, this will be where the Dependency Injection takes place
        public ScoreController()
        {
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
        }
        // Generic GET Method that returns All Scores
        [HttpGet("[action]")]
        public IEnumerable<Score> Get()
        {
            return list;
        }
        // GET method to return Scores with given Student ID (takes an int)
        [HttpGet("[action]")]
        public IActionResult GetByStudentID(int id)
        {
            var items = list.Where(s => s.StudentID == id);
            if (items == null)
            {
                return NotFound();
            }
            return new ObjectResult(items);
        }
        // GET method to return Scores within a Teachers Class (takes an int)
        [HttpGet("[action]")]
        public IActionResult GetByTeacherID(int id)
        {
            var items = list.Where(s => s.TeacherID == id);
            if (items == null)
            {
                return NotFound();
            }
            return new ObjectResult(items);
        }
        // GET method to get a score by its ID
        // Needed for Create
        [HttpGet("[action]")]
        public IActionResult GetByID(int id)
        {
            Score item = list.Find(s => s.ID == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        // Creates a new Score object in the list
        [HttpPost("[action]")]
        public IActionResult Create([FromBody] Score score)
        {
            if (score == null)
            {
                return BadRequest();
            }
            list.Add(score);
            return CreatedAtRoute("GetByID", new { id = score.ID }, score);
        }
        // Generates a random date between March, 1 2017 and now. 
        public DateTime RandomDayFunc()
        {
            DateTime from = new DateTime(year, month, date);
            DateTime to = DateTime.Now;
            TimeSpan range = new TimeSpan(to.Ticks - from.Ticks);
            return from + new TimeSpan((long)(range.Ticks * rnd.NextDouble()));
        }
    }
}