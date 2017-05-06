using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSON_Student_App.Models
{
    

    public class StudentRepository : IStudentRepository
    {

        private readonly AppContext _context;

        public StudentRepository(AppContext context)
        {
            _context = context;

            if (_context.Students.Count() == 0)
                Add(new Student {
                    FirstName = "guy",
                    LastName = "name",
                    Username = "XxguynamexX",
                    Password = "abcdefg",
                    TeacherID = 1
                });                      
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public void Add(Student item)
        {
            _context.Students.Add(item);
            _context.SaveChanges();
        }
        public Student Find(long key)
        {
            return _context.Students.FirstOrDefault(t => t.ID == key);
        }

        public Student Find(string username)
        {
            return _context.Students.FirstOrDefault(u => u.Username == username);
        }
        public void Remove(long key)
        {
            var entity = _context.Students.First(t => t.ID == key);
            _context.Students.Remove(entity);
            _context.SaveChanges();
        }
        public void Update(Student item)
        {
            _context.Students.Update(item);
            _context.SaveChanges();
        }
    }

    public class TeacherRepository : ITeacherRepository
    {
        private readonly AppContext _context;

        //public TeacherRepository(AppContext context)
        //{
        //    _context = context;

        //    //if (_context.Student.Count() == 0)
        //    //    Add(new Student { Name = "Item1" });
        // }

        public IEnumerable<Teacher> GetAll()
        {
            return _context.Teachers.ToList();
        }

        public void Add(Teacher item)
        {
            _context.Teachers.Add(item);
            _context.SaveChanges();
        }
        public Teacher Find(long key)
        {
            return _context.Teachers.FirstOrDefault(t => t.ID == key);
        }

        public Teacher Find(string username)
        {
            return _context.Teachers.FirstOrDefault(u => u.Username == username);
        }

        public void Remove(long key)
        {
            var entity = _context.Teachers.First(t => t.ID == key);
            _context.Teachers.Remove(entity);
            _context.SaveChanges();
        }
        public void Update(Teacher item)
        {
            _context.Teachers.Update(item);
            _context.SaveChanges();
        }
    }
    public class ScoreRepository : IScoreRepository
    {
        private readonly AppContext _context;

        //public TeacherRepository(AppContext context)
        //{
        //    _context = context;

        //    //if (_context.Student.Count() == 0)
        //    //    Add(new Student { Name = "Item1" });
        //}

        public IEnumerable<Score> GetAll()
        {
            return _context.Scores.ToList();
        }

        public void Add(Score item)
        {
            _context.Scores.Add(item);
            _context.SaveChanges();
        }
        public Score Find(long key)
        {
            return _context.Scores.FirstOrDefault(t => t.ID == key);
        }

        public List<Score> Find(string username)
        {
            var teacherID = _context.Teachers.FirstOrDefault(t => t.Username == username).ID;
            return _context.Scores.Where(s => s.TeacherID == teacherID).ToList();
        }
        public void Remove(long key)
        {
            var entity = _context.Scores.First(t => t.ID == key);
            _context.Scores.Remove(entity);
            _context.SaveChanges();
        }
        public void Update(Score item)
        {
            _context.Scores.Update(item);
            _context.SaveChanges();
        }
    }

}
