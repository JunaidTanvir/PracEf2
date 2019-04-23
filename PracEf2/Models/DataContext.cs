using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using PracEf2.Models.aa1;

namespace PracEf2.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("conn")
        {

        }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }

        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }


        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }







        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Publisher>().HasMany(b => b.Books)
            //    .WithRequired(p => p.Publisher)
            //    .HasForeignKey(p => p.PublisherId);


            modelBuilder.Entity<StudentCourse>()
                .HasKey(studentCourse => new {studentCourse.StudentId, studentCourse.CourseId});

            modelBuilder.Entity<StudentCourse>()
                .HasRequired<Student>(studentCourse => studentCourse.Student)
                .WithMany(student => student.StudentCourses)
                .HasForeignKey(studentCourse => studentCourse.StudentId);



            modelBuilder.Entity<StudentCourse>()
                .HasRequired<Course>(studentCourse => studentCourse.Course)
                .WithMany(course => course.StudentCourses)
                .HasForeignKey(studentCourse => studentCourse.StudentId);

            //modelBuilder.Entity<StudentCourse>()
            //    .HasOne<Student>(sc => sc.Student)
            //    .WithMany(s => s.StudentCourses)
            //    .HasForeignKey(sc => sc.SId);


            //modelBuilder.Entity<StudentCourse>()
            //    .HasOne<Course>(sc => sc.Course)
            //    .WithMany(s => s.StudentCourses)
            //    .HasForeignKey(sc => sc.CId);
        }




    }
}