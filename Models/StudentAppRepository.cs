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

            if (_context.Student.Count() == 0)
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
            return _context.Student.ToList();
        }

        public void Add(Student item)
        {
            _context.Student.Add(item);
            _context.SaveChanges();
        }
        public Student Find(long key)
        {
            return _context.Student.FirstOrDefault(t => t.ID == key);
        }
        public void Remove(long key)
        {
            var entity = _context.Student.First(t => t.ID == key);
            _context.Student.Remove(entity);
            _context.SaveChanges();
        }
        public void Update(Student item)
        {
            _context.Student.Update(item);
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
            return _context.Teacher.ToList();
        }

        public void Add(Teacher item)
        {
            _context.Teacher.Add(item);
            _context.SaveChanges();
        }
        public Teacher Find(long key)
        {
            return _context.Teacher.FirstOrDefault(t => t.ID == key);
        }
        public void Remove(long key)
        {
            var entity = _context.Teacher.First(t => t.ID == key);
            _context.Teacher.Remove(entity);
            _context.SaveChanges();
        }
        public void Update(Teacher item)
        {
            _context.Teacher.Update(item);
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

        public IEnumerable<Scores> GetAll()
        {
            return _context.Scores.ToList();
        }

        public void Add(Scores item)
        {
            _context.Scores.Add(item);
            _context.SaveChanges();
        }
        public Scores Find(long key)
        {
            return _context.Scores.FirstOrDefault(t => t.ID == key);
        }
        public void Remove(long key)
        {
            var entity = _context.Scores.First(t => t.ID == key);
            _context.Scores.Remove(entity);
            _context.SaveChanges();
        }
        public void Update(Scores item)
        {
            _context.Scores.Update(item);
            _context.SaveChanges();
        }
    }

}
