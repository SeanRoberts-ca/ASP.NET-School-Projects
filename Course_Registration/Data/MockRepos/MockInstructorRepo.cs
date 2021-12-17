using System;
using Course_Registration.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Registration.Data.MockRepos
{
    public class MockInstructorRepo : IInstructorRepo
    {
        private static List<Instructor> _instructors = new List<Instructor>
        {
            new Instructor{Id = 10000, CourseId  = 100, FirstName = "Teacher 1", LastName = "Jones 1", Email = "david1@yahoo.com"},
            new Instructor{Id = 10001, CourseId  = 101, FirstName = "Teacher 2", LastName = "Jones 2", Email = "david2@yahoo.com"},
            new Instructor{Id = 10002, CourseId  = 102, FirstName = "Teacher 3", LastName = "Jones 3", Email = "david3@yahoo.com"},
            new Instructor{Id = 10003, CourseId  = 103, FirstName = "Teacher 4", LastName = "Jones 4", Email = "david4@yahoo.com"},
            new Instructor{Id = 10004, CourseId  = 104, FirstName = "Teacher 5", LastName = "Jones 5", Email = "david5@yahoo.com"},
            new Instructor{Id = 10005, CourseId  = 105, FirstName = "Teacher 6", LastName = "Jones 6", Email = "david6@yahoo.com"},
            new Instructor{Id = 10006, CourseId  = 106, FirstName = "Teacher 7", LastName = "Jones 7", Email = "david7@yahoo.com"},
            new Instructor{Id = 10007, CourseId  = 107, FirstName = "Teacher 8", LastName = "Jones 8", Email = "david8@yahoo.com"},
            new Instructor{Id = 10008, CourseId  = 108, FirstName = "Teacher 9", LastName = "Jones 9", Email = "david9@yahoo.com"},
            new Instructor{Id = 10009, CourseId  = 109, FirstName = "Teacher 10", LastName = "Jones 10", Email = "david10@yahoo.com"},
            new Instructor{Id = 10010, CourseId  = 110, FirstName = "Teacher 11", LastName = "Jones 11", Email = "david11@yahoo.com"}
        };


        public void Create(Instructor instructor)
        {
            int id = _instructors.Max(c => c.Id) + 1;
            instructor.Id = id;

            int CourseId = _instructors.Max(c => c.CourseId) + 1;
            instructor.CourseId = CourseId;

            _instructors.Add(instructor);
        }

        public IEnumerable<Instructor> GetAll()
        {
            return _instructors;
        }

        public Instructor GetById(int id)
        {
            var instructor = _instructors.Where(i => i.Id == id).FirstOrDefault();

            return instructor;
        }

    }
}