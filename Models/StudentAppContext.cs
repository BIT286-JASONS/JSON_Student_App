using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSON_Student_App.Models
{
   
        public class StudentAppContext : DbContext
        {
            public StudentAppContext(DbContextOptions<StudentAppContext> options)
            : base(options)
            {
            }

            public DbSet<Student> Students { get; set; }
            public DbSet<Teacher> Teachers { get; set; }
            public DbSet<Score> Scores { get; set; }
        }
}
