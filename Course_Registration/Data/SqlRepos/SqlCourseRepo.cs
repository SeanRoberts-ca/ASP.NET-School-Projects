using Course_Registration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Registration.Data.SqlRepos
{
    public class SqlCourseRepo : ICourseRepo
    {
        private readonly SchoolContext _context;

        public SqlCourseRepo(SchoolContext context)
        {
            _context = context;

        }

        public void Create(Course course)
        {

            if (course == null)
            {
                throw new ArgumentException(nameof(course));
            }

            _context.Courses.Add(course);

            SaveChanges();

        }

        public IEnumerable<Course> GetAll()
        {
            return _context.Courses.ToList();
        }

        public Course GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
