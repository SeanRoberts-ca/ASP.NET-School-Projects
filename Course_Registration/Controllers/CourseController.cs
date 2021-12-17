using Course_Registration.Data;
using Course_Registration.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Registration.Controllers
{
    public class CourseController : Controller
    {

        private readonly ICourseRepo _courseRepo;

        public CourseController(ICourseRepo repocourse)
        {
            _courseRepo = repocourse;
        }

        public ActionResult<IEnumerable<Course>> Index()
        {
            var course = _courseRepo.GetAll();
            return View(course);
        }

        public ActionResult Create()
        {
            return View();
        }

        //[HttpGet]
        //public ActionResult Create()
        //{

        //}
        [HttpPost]
        public ActionResult Create(Course course)
        {
            //add new vendor to collection

            _courseRepo.Create(course);
            return RedirectToAction("Index");
        }


    }
}
