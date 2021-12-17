using Course_Registration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Registration.Data.SqlRepos
{
    public class SqlCourseStudentRepo : ICourseStudentRepo
    {

        private readonly SchoolContext _context;

        public SqlCourseStudentRepo(SchoolContext context)
        {
            _context = context;

        }

        public IEnumerable<CourseStudent> GetAll()
        {
            return _context.CourseStudents.ToList();
        }

        public CourseStudent GetByCourseId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
