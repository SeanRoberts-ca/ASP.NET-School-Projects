using System;
using System.Collections.Generic;
using Course_Registration.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Registration.Data
{
    public interface IStudentRepo
    {
        public IEnumerable<Student> GetAll();
        public Student GetById(int id);
        void Create(Student student);
    }
}
