using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSON_Student_App.Models
{
   
        public class AppContext : DbContext
        {
        public AppContext(DbContextOptions<AppContext> options)
            : base(options)
        {
        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Score> Score { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Scores> Scores { get; set; }
    }
}
