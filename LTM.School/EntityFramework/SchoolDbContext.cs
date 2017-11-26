using LTM.School.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LTM.School.EntityFramework
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Student>().ToTable("Student");
            //modelBuilder.Entity<Course>().ToTable("Course").Property(c => c.CourseId).ValueGeneratedNever();//表示生成数据库时不会自动生成值
            //modelBuilder.Entity<Enrollment>().ToTable("Enrollment").HasOne(c => c.Student).WithMany(c => c.Enrollments).HasForeignKey(c => c.StudentId);
            //modelBuilder.Entity<Enrollment>().HasOne(c => c.Course).WithMany(c => c.Enrollments).HasForeignKey(c => c.CourseId);

            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Course>().ToTable("Course").Property(c => c.CourseId).ValueGeneratedNever();//表示生成数据库时不会自动生成值
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
        }
    }
}
