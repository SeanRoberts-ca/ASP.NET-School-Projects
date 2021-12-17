using System;
using Course_Registration.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Registration.Data.MockRepos
{
    public class MockStudentRepo : IStudentRepo
    {

        private static List<Student> _students = new List<Student>
        {
            new Student{StudentId= 200 , FirstName  = "Sean 1", LastName = "Roberts1", Email  = "info@seanroberts.ca", PhoneNumber = "204-899-1142"},
            new Student{StudentId= 201 , FirstName  = "Sean 2", LastName = "Roberts2", Email  = "info@google.ca", PhoneNumber = "204-999-2142"},
            new Student{StudentId= 202 , FirstName  = "Sean 3", LastName = "Roberts3", Email  = "info@yahoo.ca", PhoneNumber = "204-301-3142"},
            new Student{StudentId= 203 , FirstName  = "Sean 4", LastName = "Roberts4", Email  = "info@facebook.ca", PhoneNumber = "204-733-4142"},
            new Student{StudentId= 204 , FirstName  = "Sean 5", LastName = "Roberts5", Email  = "info@apple.ca", PhoneNumber = "204-541-5142"},
            new Student{StudentId= 205 , FirstName  = "Sean 6", LastName = "Roberts6", Email  = "info@bing.ca", PhoneNumber = "204-598-6142"},
            new Student{StudentId= 206 , FirstName  = "Sean 7", LastName = "Roberts7", Email  = "info@yelp.ca", PhoneNumber = "204-321-7142"},
            new Student{StudentId= 207 , FirstName  = "Sean 8", LastName = "Roberts8", Email  = "info@mysite.ca", PhoneNumber = "204-852-8142"},
            new Student{StudentId= 208 , FirstName  = "Sean 9", LastName = "Roberts9", Email  = "info@newssite.ca", PhoneNumber = "204-789-9142"},
            new Student{StudentId= 209 , FirstName  = "Sean 10", LastName = "Roberts10", Email  = "info@design.ca", PhoneNumber = "897-899-3142"}
        };

        public void Create(Student student)
        {
            int codeStudentId = _students.Max(s => s.StudentId) + 1;
            student.StudentId = codeStudentId;
            _students.Add(student);
        }

        public IEnumerable<Student> GetAll()
        {
            return _students;
        }
        public Student GetById(int id)
        {
            var student = _students.Where(s => s.StudentId == id).FirstOrDefault();

            return student;
        }
    }
}
