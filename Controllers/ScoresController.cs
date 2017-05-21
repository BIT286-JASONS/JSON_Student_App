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
    public class ScoresController : Controller
    {
        private readonly json_app_dbContext _context;

        public ScoresController(json_app_dbContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public IEnumerable<Scores> Get()
        {
            return _context.Scores;
        }
        // GET method to return Scores with given Student ID (takes an int)
        [HttpGet("[action]")]
        public IActionResult GetByStudentID(int id)
        {
            var items = _context.Scores.Where(s => s.StudentId == id);
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
            var items = _context.Scores.Where(s => s.TeacherId == id);
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
            Scores item = _context.Scores.FirstOrDefault(s => s.ScoresId == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        // Creates a new Score object in the _context.Scores
        [HttpPost("[action]")]
        public IActionResult Create([FromBody] Scores score)
        {
            if (score == null)
            {
                return BadRequest();
            }
            _context.Scores.Add(score);
            return CreatedAtRoute("GetByID", new { id = score.ScoresId }, score);
        }
    }
}
