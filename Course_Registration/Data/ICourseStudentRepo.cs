using System;
using System.Collections.Generic;
using Course_Registration.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Registration.Data
{
    public interface ICourseStudentRepo
    {
        public IEnumerable<CourseStudent> GetAll();
        public CourseStudent GetByCourseId(int id);
    }
}
