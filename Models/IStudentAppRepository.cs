using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSON_Student_App.Models
{
    public interface IStudentRepository
    {
        void Add(Student item);
        IEnumerable<Student> GetAll();
        Student Find(long key);
        Student Find(string username);
        void Remove(long key);
        void Update(Student item);
    }
    public interface ITeacherRepository
    {
        void Add(Teacher item);
        IEnumerable<Teacher> GetAll();
        Teacher Find(long key);
        Teacher Find(string username);
        void Remove(long key);
        void Update(Teacher item);
    }
    public interface IScoreRepository
    {
        void Add(Score item);
        IEnumerable<Score> GetAll();
        Score Find(long key);
        List<Score> Find(string teachername);
        void Remove(long key);
        void Update(Score item);
    }


}