using System;
using System.Collections.Generic;
using Course_Registration.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Registration.Data
{
    public interface ICourseRepo
    {
        public IEnumerable<Course> GetAll();
        public Course GetById(int id);
        void Create(Course course);

    }
}
