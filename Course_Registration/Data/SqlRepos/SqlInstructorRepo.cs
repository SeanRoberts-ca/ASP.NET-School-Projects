using Course_Registration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Registration.Data.SqlRepos
{
    public class SqlInstructorRepo : IInstructorRepo
    {
        private readonly SchoolContext _context;

        public SqlInstructorRepo(SchoolContext context)
        {
            _context = context;

        }

        public void Create(Instructor instructor)
        {
            if (instructor == null)
            {
                throw new ArgumentException(nameof(instructor));
            }

            _context.Instructors.Add(instructor);

            SaveChanges();
        }

        public IEnumerable<Instructor> GetAll()
        {
            return _context.Instructors.ToList();
        }

        public Instructor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
