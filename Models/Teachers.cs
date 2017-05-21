using System;
using System.Collections.Generic;

namespace JSON_Student_App.Models
{
    public partial class Teachers
    {
        public Teachers()
        {
            Scores = new HashSet<Scores>();
            Students = new HashSet<Students>();
        }

        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string TeacherPassword { get; set; }
        public string Email { get; set; }
        public string TeacherIp { get; set; }
        public byte[] TeacherImage { get; set; }

        public virtual ICollection<Scores> Scores { get; set; }
        public virtual ICollection<Students> Students { get; set; }
    }
}
