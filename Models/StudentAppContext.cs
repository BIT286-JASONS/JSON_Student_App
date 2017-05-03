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
        public DbSet<Student> Student { get; set; }
        public DbSet<Shapes_Game> Shapes_Game { get; set; }
        public DbSet<Teacher> Teacher { get; set; }

    }
}
