using Course_Registration.Data;
using Course_Registration.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Registration.Controllers
{
    public class InstructorController : Controller
    {

        private readonly IInstructorRepo _instructorRepo;

        public InstructorController(IInstructorRepo repoinstructor)
        {
            _instructorRepo = repoinstructor;
        }

        public ActionResult<IEnumerable<Instructor>> Index()
        {
            var instructor = _instructorRepo.GetAll();
            return View(instructor);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Instructor instructor)
        {

            _instructorRepo.Create(instructor);
            return RedirectToAction("Index");
        }


    }
}
