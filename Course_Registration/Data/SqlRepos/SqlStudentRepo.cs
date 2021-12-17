using Course_Registration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Registration.Data.SqlRepos
{
    public class SqlStudentRepo : IStudentRepo
    {
        private readonly SchoolContext _context;

        public SqlStudentRepo(SchoolContext context)
        {
            _context = context;

        }

        public void Create(Student student)
        {
            if (student == null)
            {
                throw new ArgumentException(nameof(student));
            }

            _context.Student.Add(student);

            SaveChanges();
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Student.ToList();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
