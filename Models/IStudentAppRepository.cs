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
        void Remove(long key);
        void Update(Student item);      
    }
    public interface ITeacherRepository
    {
        void Add(Teacher item);
        IEnumerable<Teacher> GetAll();
        Teacher Find(long key);
        void Remove(long key);
        void Update(Teacher item);
    }
    public interface IScoreRepository
    {
        void Add(Score item);
        IEnumerable<Score> GetAll();
        Scores Find(long key);
        void Remove(long key);
        void Update(Scores item);
    }


}
