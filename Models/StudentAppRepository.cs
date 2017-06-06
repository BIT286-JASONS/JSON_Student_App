using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSON_Student_App.Models
{


    public class StudentRepository : IStudentRepository
    {

        private readonly StudentAppContext _context;

        public StudentRepository(StudentAppContext context)
        {
            _context = context;

            if (_context.Students.Count() == 0)
            {
                Add(new Student
                {
                    FirstName = "Joe",
                    LastName = "Thompson",
                    Username = "jthomp",
                    Password = "1234",
                    TeacherID = 1
                });
                Add(new Student
                {
                    FirstName = "Kimmy",
                    LastName = "Schmidt",
                    Username = "kschmidt",
                    Password = "1234",
                    TeacherID = 1
                });
                Add(new Student
                {
                    FirstName = "Jerome",
                    LastName = "Lewis",
                    Username = "jlewis",
                    Password = "1234",
                    TeacherID = 1
                });
                Add(new Student
                {
                    FirstName = "Micky",
                    LastName = "O'rilley",
                    Username = "mickyo",
                    Password = "1234",
                    TeacherID = 1
                });
                Add(new Student
                {
                    FirstName = "Sanjay",
                    LastName = "Patel",
                    Username = "spatel",
                    Password = "1234",
                    TeacherID = 1
                });
                Add(new Student
                {
                    FirstName = "Martha",
                    LastName = "Fleming",
                    Username = "mfleming",
                    Password = "1234",
                    TeacherID = 1
                });
            }
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
        private readonly StudentAppContext _context;

        public TeacherRepository(StudentAppContext context)
        {
            _context = context;

            if (_context.Teachers.Count() == 0)
            {
                Add(new Teacher { FirstName = "Bob", LastName = "Smith", Username = "mathrules", Password = "password" });
                Add(new Teacher { FirstName = "Sandra", LastName = "Klien", Username = "sandraklien", Password = "password" });
            }
        }

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
        private readonly StudentAppContext _context;

        public ScoreRepository(StudentAppContext context)
        {
            _context = context;

            if (_context.Scores.Count() == 0)
            {
                Add(new Score { GameID = 1, StudentID = 4, NumberQuestions = 10, NumberCorrect = 8, Time = RandomDayFunc(), TeacherID = 1 });
                Add(new Score { GameID = 3, StudentID = 1, NumberQuestions = 10, NumberCorrect = 3, Time = RandomDayFunc(), TeacherID = 1 });
                Add(new Score { GameID = 2, StudentID = 3, NumberQuestions = 10, NumberCorrect = 4, Time = RandomDayFunc(), TeacherID = 1 });
                Add(new Score { GameID = 4, StudentID = 4, NumberQuestions = 10, NumberCorrect = 9, Time = RandomDayFunc(), TeacherID = 1 });
                Add(new Score { GameID = 3, StudentID = 5, NumberQuestions = 10, NumberCorrect = 4, Time = RandomDayFunc(), TeacherID = 1 });
                Add(new Score { GameID = 1, StudentID = 1, NumberQuestions = 10, NumberCorrect = 4, Time = RandomDayFunc(), TeacherID = 1 });
                Add(new Score { GameID = 1, StudentID = 3, NumberQuestions = 10, NumberCorrect = 6, Time = RandomDayFunc(), TeacherID = 1 });
                Add(new Score { GameID = 2, StudentID = 2, NumberQuestions = 10, NumberCorrect = 3, Time = RandomDayFunc(), TeacherID = 1 });
                Add(new Score { GameID = 4, StudentID = 3, NumberQuestions = 10, NumberCorrect = 5, Time = RandomDayFunc(), TeacherID = 1 });
                Add(new Score { GameID = 5, StudentID = 5, NumberQuestions = 10, NumberCorrect = 4, Time = RandomDayFunc(), TeacherID = 1 });
                Add(new Score { GameID = 6, StudentID = 1, NumberQuestions = 10, NumberCorrect = 4, Time = RandomDayFunc(), TeacherID = 1 });
            }
        }

        public DateTime RandomDayFunc()
        {
            DateTime from = new DateTime(2017, 3, 1);
            DateTime to = DateTime.Now;
            var rnd = new Random();
            TimeSpan range = new TimeSpan(to.Ticks - from.Ticks);
            return from + new TimeSpan((long)(range.Ticks * rnd.NextDouble()));
        }

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