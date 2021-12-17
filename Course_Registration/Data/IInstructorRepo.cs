using System;
using System.Collections.Generic;
using Course_Registration.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Registration.Data
{
    public interface IInstructorRepo
    {
        public IEnumerable<Instructor> GetAll();
        public Instructor GetById(int id);
        void Create(Instructor instructor);
    }
}
