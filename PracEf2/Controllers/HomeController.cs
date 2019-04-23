using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracEf2.Models;
using PracEf2.Models.aa1;

namespace PracEf2.Controllers
{
    public class HomeController : Controller
    {
        private DataContext db = new DataContext();
        public ActionResult Index()
        {


            var Students = new List<Student>()
            {
                new Student() {StudentId = 1, Name = "Ali"},
                new Student() {StudentId = 2, Name = "Bilal"},
                new Student() {StudentId = 3, Name = "Careem"},
            };

            var Courses = new List<Course>()
            {
                new Course() {CourseId = 501, CourseName = "PF", Description = " Programing"},
                new Course() {CourseId = 502, CourseName = "CalMTH", Description = " Maths"},
                new Course() {CourseId = 503, CourseName = "EngLit", Description = " English"},
                new Course() {CourseId = 504, CourseName = "OOP", Description = " Programing"},
                new Course() {CourseId = 505, CourseName = "LAMTH", Description = " Maths"},
                new Course() {CourseId = 506, CourseName = "EngGramer", Description = " English"},
            };



            var studentCourses = new List<StudentCourse>()
            {
                new StudentCourse() {Student = Students[0], Course = Courses[0]},
                new StudentCourse() {Student = Students[0], Course = Courses[3]},
                new StudentCourse() {Student = Students[2], Course = Courses[2]},
                new StudentCourse() {Student = Students[2], Course = Courses[5]},
                new StudentCourse() {Student = Students[1], Course = Courses[1]},
                new StudentCourse() {Student = Students[1], Course = Courses[4]},
            };


            //db.Students.AddRange(Students);
            //db.Courses.AddRange(Courses);
            //db.StudentCourses.AddRange(studentCourses);

            StudentCourse studentCourse = new StudentCourse()
            {
                Student = Students[0],
                Course = Courses[0]
            };


            db.StudentCourses.Add(studentCourse);
            db.SaveChanges();


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



    }
}