using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracEf2.Models.aa1
{
    public class Student
    {
        public Student()
        {
            StudentCourses = new List<StudentCourse>();
        }
        public int StudentId { get; set; }
        public string Name { get; set; }

        public IList<StudentCourse> StudentCourses { get; set; }
    }

    public class Course
    {
        public Course()
        {
            StudentCourses = new List<StudentCourse>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }

        public IList<StudentCourse> StudentCourses { get; set; }
    }


    public class StudentCourse
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}