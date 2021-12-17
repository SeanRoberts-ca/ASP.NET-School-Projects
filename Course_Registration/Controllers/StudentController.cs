using Course_Registration.Data;
using Course_Registration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Registration.Controllers
{
    public class StudentController : Controller
    {

        private readonly IStudentRepo _studentRepo;
        private readonly ICourseRepo _courseRepo;
        private readonly ICourseStudentRepo _courseStudentRepo;

        public StudentController(IStudentRepo repostudent, ICourseRepo repocourse, ICourseStudentRepo coursestudentrepo)
        {
            _studentRepo = repostudent;
            _courseRepo = repocourse;
            _courseStudentRepo = coursestudentrepo;
        }

        public ActionResult<IEnumerable<Student>> Index()
        {
            var students = _studentRepo.GetAll();
            return View(students);
        }
        public ActionResult Create()
        {
            var courses = _courseRepo.GetAll().ToList();
            ViewBag.Courses = new SelectList(courses, "CourseId", "CourseName");
            return View();
        }

        //[HttpGet]
        //public ActionResult Create()
        //{

        //}
        [HttpPost]
        public ActionResult Create(Student student)
        {
  

            //var myStudent = student.ToString();
            //foreach (int CourseId in myStudent)
            //{
            //    _courseStudentRepo.Add(myStudent);
            //}



            _studentRepo.Create(student);
            return RedirectToAction("Index");
        }


    }
}
