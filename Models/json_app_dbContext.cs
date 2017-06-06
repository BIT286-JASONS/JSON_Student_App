using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JSON_Student_App.Models
{
    public partial class json_app_dbContext : DbContext
    {
        public virtual DbSet<Scores> Scores { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }

        public json_app_dbContext(DbContextOptions<json_app_dbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Scores>(entity =>
            {
                entity.Property(e => e.ScoresId)
                    .HasColumnName("Scores_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttemptTime)
                    .HasColumnName("Attempt_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.GameId).HasColumnName("Game_ID");

                entity.Property(e => e.NumberCorrect).HasColumnName("Number_Correct");

                entity.Property(e => e.NumberQuestions).HasColumnName("Number_Questions");

                entity.Property(e => e.StudentId).HasColumnName("Student_ID");

                entity.Property(e => e.TeacherId).HasColumnName("Teacher_ID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Scores)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Scores__Student___3B75D760");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Scores)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Scores__Teacher___3C69FB99");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.StudentId)
                    .HasName("PK__Students__A2F4E9AC6C97B1B6");

                entity.Property(e => e.StudentId)
                    .HasColumnName("Student_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First_Name")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last_Name")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.RocketType).HasColumnName("rocket_type");

                entity.Property(e => e.SpacePennies).HasColumnName("space_pennies");

                entity.Property(e => e.StudentImage)
                    .HasColumnName("student_image")
                    .HasMaxLength(64);

                entity.Property(e => e.StudentIp)
                    .HasColumnName("Student_IP")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.StudentPassword)
                    .IsRequired()
                    .HasColumnName("STUDENT_PASSWORD")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.TeacherId).HasColumnName("Teacher_ID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnType("varchar(25)");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Students__Teache__38996AB5");
            });

            modelBuilder.Entity<Teachers>(entity =>
            {
                entity.HasKey(e => e.TeacherId)
                    .HasName("PK__Teachers__92FF4C8BCA6164B4");

                entity.Property(e => e.TeacherId)
                    .HasColumnName("Teacher_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First_Name")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last_Name")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.TeacherImage)
                    .HasColumnName("teacher_image")
                    .HasMaxLength(64);

                entity.Property(e => e.TeacherIp)
                    .HasColumnName("Teacher_IP")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.TeacherPassword)
                    .IsRequired()
                    .HasColumnName("Teacher_Password")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnType("varchar(25)");
            });
        }
    }
}