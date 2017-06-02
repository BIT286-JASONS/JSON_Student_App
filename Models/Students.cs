using System;
using System.Collections.Generic;

namespace JSON_Student_App.Models
{
    public partial class Students
    {
        public Students()
        {
            Scores = new HashSet<Scores>();
        }

        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string StudentPassword { get; set; }
        public string StudentIp { get; set; }
        public byte[] StudentImage { get; set; }
        public int? SpacePennies { get; set; }
        public int? RocketType { get; set; }

        public virtual ICollection<Scores> Scores { get; set; }
        public virtual Teachers Teacher { get; set; }
    }
}
