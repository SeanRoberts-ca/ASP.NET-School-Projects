using Course_Registration.Data;
using Course_Registration.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Registration.Controllers
{
    public class CourseStudentController : Controller
    {

        private readonly ICourseStudentRepo _courseStudentRepo;

        public CourseStudentController(ICourseStudentRepo repo)
        {
            _courseStudentRepo = repo;
        }

        public ActionResult<IEnumerable<CourseStudent>> Index()
        {
            var cousestudents = _courseStudentRepo.GetAll();
            return View(cousestudents);
        }

        public IEnumerable<string> GetCourseStudentsID(int? id)
        {
            var res = _courseStudentRepo.GetAll().Where(p => p.CourseIdjq == id)
            .Select(p => p.FirstNamejq + "\t" + p.LastNamejq + "\t" + p.Emailjq + "<br>");

            if (res == null || res.Count() == 0){
                return new List<string> { "No Students found" };
            }
            
            return res;

        }


    }
}
