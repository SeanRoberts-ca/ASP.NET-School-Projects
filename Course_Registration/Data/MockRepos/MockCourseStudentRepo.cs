using System;
using Course_Registration.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Registration.Data.MockRepos
{
    public class MockCourseStudentRepo : ICourseStudentRepo
    {

        private static List<CourseStudent> _courseStudents = new List<CourseStudent>
        {
            new CourseStudent{id = 1, CourseIdjq = 100, StudentIdjq= 200 , FirstNamejq  = "Sean 1", LastNamejq = "Roberts1", Emailjq  = "info@seanroberts.ca"},
            new CourseStudent{id = 2, CourseIdjq = 100, StudentIdjq= 201 , FirstNamejq  = "Sean 2", LastNamejq = "Roberts2", Emailjq  = "info@google.ca"},
            new CourseStudent{id = 3, CourseIdjq = 100, StudentIdjq= 202 , FirstNamejq  = "Sean 3", LastNamejq = "Roberts3", Emailjq  = "info@yahoo.ca"},
            new CourseStudent{id = 4, CourseIdjq = 100, StudentIdjq= 203 , FirstNamejq  = "Sean 4", LastNamejq = "Roberts4", Emailjq  = "info@facebook.ca"},
            new CourseStudent{id = 5, CourseIdjq = 100, StudentIdjq= 204 , FirstNamejq  = "Sean 5", LastNamejq = "Roberts5", Emailjq  = "info@apple.ca"},
            new CourseStudent{id = 6, CourseIdjq = 100, StudentIdjq= 205 , FirstNamejq  = "Sean 6", LastNamejq = "Roberts6", Emailjq  = "info@bing.ca"},
            new CourseStudent{id = 7, CourseIdjq = 100, StudentIdjq= 206 , FirstNamejq  = "Sean 7", LastNamejq = "Roberts7", Emailjq  = "info@yelp.ca"},
            new CourseStudent{id = 8, CourseIdjq = 100, StudentIdjq= 207 , FirstNamejq  = "Sean 8", LastNamejq = "Roberts8", Emailjq  = "info@mysite.ca"},
            new CourseStudent{id = 9, CourseIdjq = 100, StudentIdjq= 208 , FirstNamejq  = "Sean 9", LastNamejq = "Roberts9", Emailjq  = "info@newssite.ca"},
            new CourseStudent{id = 10, CourseIdjq = 100, StudentIdjq= 209 , FirstNamejq  = "Sean 10", LastNamejq = "Roberts10", Emailjq  = "info@design.ca"},
            new CourseStudent{id = 11, CourseIdjq = 100, StudentIdjq= 200 , FirstNamejq  = "Sean 1", LastNamejq = "Roberts1", Emailjq  = "info@seanroberts.ca"},
            new CourseStudent{id = 12, CourseIdjq = 101, StudentIdjq= 201 , FirstNamejq  = "Sean 2", LastNamejq = "Roberts2", Emailjq  = "info@google.ca"},
            new CourseStudent{id = 13, CourseIdjq = 101, StudentIdjq= 202 , FirstNamejq  = "Sean 3", LastNamejq = "Roberts3", Emailjq  = "info@yahoo.ca"},
            new CourseStudent{id = 14, CourseIdjq = 101, StudentIdjq= 203 , FirstNamejq  = "Sean 4", LastNamejq = "Roberts4", Emailjq  = "info@facebook.ca"},
            new CourseStudent{id = 15, CourseIdjq = 101, StudentIdjq= 204 , FirstNamejq  = "Sean 5", LastNamejq = "Roberts5", Emailjq  = "info@apple.ca"},
            new CourseStudent{id = 16, CourseIdjq = 101, StudentIdjq= 205 , FirstNamejq  = "Sean 6", LastNamejq = "Roberts6", Emailjq  = "info@bing.ca"},
            new CourseStudent{id = 17, CourseIdjq = 101, StudentIdjq= 206 , FirstNamejq  = "Sean 7", LastNamejq = "Roberts7", Emailjq  = "info@yelp.ca"},
            new CourseStudent{id = 18, CourseIdjq = 101, StudentIdjq= 207 , FirstNamejq  = "Sean 8", LastNamejq = "Roberts8", Emailjq  = "info@mysite.ca"},
            new CourseStudent{id = 19, CourseIdjq = 101, StudentIdjq= 208 , FirstNamejq  = "Sean 9", LastNamejq = "Roberts9", Emailjq  = "info@newssite.ca"},
            new CourseStudent{id = 20, CourseIdjq = 101, StudentIdjq= 209 , FirstNamejq  = "Sean 10", LastNamejq = "Roberts10", Emailjq  = "info@design.ca"},
            new CourseStudent{id = 21, CourseIdjq = 102, StudentIdjq= 201 , FirstNamejq  = "Sean 2", LastNamejq = "Roberts2", Emailjq  = "info@google.ca"},
            new CourseStudent{id = 22, CourseIdjq = 102, StudentIdjq= 202 , FirstNamejq  = "Sean 3", LastNamejq = "Roberts3", Emailjq  = "info@yahoo.ca"},
            new CourseStudent{id = 23, CourseIdjq = 102, StudentIdjq= 203 , FirstNamejq  = "Sean 4", LastNamejq = "Roberts4", Emailjq  = "info@facebook.ca"},
            new CourseStudent{id = 24, CourseIdjq = 102, StudentIdjq= 204 , FirstNamejq  = "Sean 5", LastNamejq = "Roberts5", Emailjq  = "info@apple.ca"},
            new CourseStudent{id = 25, CourseIdjq = 102, StudentIdjq= 205 , FirstNamejq  = "Sean 6", LastNamejq = "Roberts6", Emailjq  = "info@bing.ca"},
            new CourseStudent{id = 26, CourseIdjq = 102, StudentIdjq= 206 , FirstNamejq  = "Sean 7", LastNamejq = "Roberts7", Emailjq  = "info@yelp.ca"},
            new CourseStudent{id = 27, CourseIdjq = 102, StudentIdjq= 207 , FirstNamejq  = "Sean 8", LastNamejq = "Roberts8", Emailjq  = "info@mysite.ca"},
            new CourseStudent{id = 28, CourseIdjq = 102, StudentIdjq= 208 , FirstNamejq  = "Sean 9", LastNamejq = "Roberts9", Emailjq  = "info@newssite.ca"},
            new CourseStudent{id = 29, CourseIdjq = 102, StudentIdjq= 209 , FirstNamejq  = "Sean 10", LastNamejq = "Roberts10", Emailjq  = "info@design.ca"},
            new CourseStudent{id = 30, CourseIdjq = 103, StudentIdjq= 204 , FirstNamejq  = "Sean 5", LastNamejq = "Roberts5", Emailjq  = "info@apple.ca"},
            new CourseStudent{id = 31, CourseIdjq = 103, StudentIdjq= 205 , FirstNamejq  = "Sean 6", LastNamejq = "Roberts6", Emailjq  = "info@bing.ca"},
            new CourseStudent{id = 32, CourseIdjq = 103, StudentIdjq= 206 , FirstNamejq  = "Sean 7", LastNamejq = "Roberts7", Emailjq  = "info@yelp.ca"},
            new CourseStudent{id = 33, CourseIdjq = 103, StudentIdjq= 207 , FirstNamejq  = "Sean 8", LastNamejq = "Roberts8", Emailjq  = "info@mysite.ca"},
            new CourseStudent{id = 34, CourseIdjq = 103, StudentIdjq= 208 , FirstNamejq  = "Sean 9", LastNamejq = "Roberts9", Emailjq  = "info@newssite.ca"},
            new CourseStudent{id = 35, CourseIdjq = 103, StudentIdjq= 209 , FirstNamejq  = "Sean 10", LastNamejq = "Roberts10", Emailjq  = "info@design.ca"},
            new CourseStudent{id = 36, CourseIdjq = 104, StudentIdjq= 204 , FirstNamejq  = "Sean 5", LastNamejq = "Roberts5", Emailjq  = "info@apple.ca"},
            new CourseStudent{id = 37, CourseIdjq = 104, StudentIdjq= 205 , FirstNamejq  = "Sean 6", LastNamejq = "Roberts6", Emailjq  = "info@bing.ca"},
            new CourseStudent{id = 38, CourseIdjq = 104, StudentIdjq= 206 , FirstNamejq  = "Sean 7", LastNamejq = "Roberts7", Emailjq  = "info@yelp.ca"},
            new CourseStudent{id = 39, CourseIdjq = 104, StudentIdjq= 207 , FirstNamejq  = "Sean 8", LastNamejq = "Roberts8", Emailjq  = "info@mysite.ca"},
            new CourseStudent{id = 40, CourseIdjq = 104, StudentIdjq= 208 , FirstNamejq  = "Sean 9", LastNamejq = "Roberts9", Emailjq  = "info@newssite.ca"},
            new CourseStudent{id = 41, CourseIdjq = 104, StudentIdjq= 209 , FirstNamejq  = "Sean 10", LastNamejq = "Roberts10", Emailjq  = "info@design.ca"},
            new CourseStudent{id = 42, CourseIdjq = 105, StudentIdjq= 204 , FirstNamejq  = "Sean 5", LastNamejq = "Roberts5", Emailjq  = "info@apple.ca"},
            new CourseStudent{id = 43, CourseIdjq = 105, StudentIdjq= 205 , FirstNamejq  = "Sean 6", LastNamejq = "Roberts6", Emailjq  = "info@bing.ca"},
            new CourseStudent{id = 44, CourseIdjq = 105, StudentIdjq= 206 , FirstNamejq  = "Sean 7", LastNamejq = "Roberts7", Emailjq  = "info@yelp.ca"},
            new CourseStudent{id = 45, CourseIdjq = 105, StudentIdjq= 207 , FirstNamejq  = "Sean 8", LastNamejq = "Roberts8", Emailjq  = "info@mysite.ca"},
            new CourseStudent{id = 46, CourseIdjq = 105, StudentIdjq= 208 , FirstNamejq  = "Sean 9", LastNamejq = "Roberts9", Emailjq  = "info@newssite.ca"},
            new CourseStudent{id = 47, CourseIdjq = 105, StudentIdjq= 209 , FirstNamejq  = "Sean 10", LastNamejq = "Roberts10", Emailjq  = "info@design.ca"},
            new CourseStudent{id = 48, CourseIdjq = 106, StudentIdjq= 200 , FirstNamejq  = "Sean 1", LastNamejq = "Roberts1", Emailjq  = "info@seanroberts.ca"},
            new CourseStudent{id = 49, CourseIdjq = 106, StudentIdjq= 201 , FirstNamejq  = "Sean 2", LastNamejq = "Roberts2", Emailjq  = "info@google.ca"},
            new CourseStudent{id = 50, CourseIdjq = 106, StudentIdjq= 202 , FirstNamejq  = "Sean 3", LastNamejq = "Roberts3", Emailjq  = "info@yahoo.ca"},
            new CourseStudent{id = 51, CourseIdjq = 106, StudentIdjq= 203 , FirstNamejq  = "Sean 4", LastNamejq = "Roberts4", Emailjq  = "info@facebook.ca"},
            new CourseStudent{id = 52, CourseIdjq = 106, StudentIdjq= 204 , FirstNamejq  = "Sean 5", LastNamejq = "Roberts5", Emailjq  = "info@apple.ca"},
            new CourseStudent{id = 53, CourseIdjq = 106, StudentIdjq= 205 , FirstNamejq  = "Sean 6", LastNamejq = "Roberts6", Emailjq  = "info@bing.ca"},
            new CourseStudent{id = 54, CourseIdjq = 106, StudentIdjq= 206 , FirstNamejq  = "Sean 7", LastNamejq = "Roberts7", Emailjq  = "info@yelp.ca"},
            new CourseStudent{id = 55, CourseIdjq = 107, StudentIdjq= 200 , FirstNamejq  = "Sean 1", LastNamejq = "Roberts1", Emailjq  = "info@seanroberts.ca"},
            new CourseStudent{id = 56, CourseIdjq = 107, StudentIdjq= 201 , FirstNamejq  = "Sean 2", LastNamejq = "Roberts2", Emailjq  = "info@google.ca"},
            new CourseStudent{id = 57, CourseIdjq = 107, StudentIdjq= 202 , FirstNamejq  = "Sean 3", LastNamejq = "Roberts3", Emailjq  = "info@yahoo.ca"},
            new CourseStudent{id = 58, CourseIdjq = 107, StudentIdjq= 203 , FirstNamejq  = "Sean 4", LastNamejq = "Roberts4", Emailjq  = "info@facebook.ca"},
            new CourseStudent{id = 59, CourseIdjq = 107, StudentIdjq= 204 , FirstNamejq  = "Sean 5", LastNamejq = "Roberts5", Emailjq  = "info@apple.ca"},
            new CourseStudent{id = 60, CourseIdjq = 107, StudentIdjq= 205 , FirstNamejq  = "Sean 6", LastNamejq = "Roberts6", Emailjq  = "info@bing.ca"},
            new CourseStudent{id = 61, CourseIdjq = 107, StudentIdjq= 206 , FirstNamejq  = "Sean 7", LastNamejq = "Roberts7", Emailjq  = "info@yelp.ca"},
            new CourseStudent{id = 62, CourseIdjq = 108, StudentIdjq= 200 , FirstNamejq  = "Sean 1", LastNamejq = "Roberts1", Emailjq  = "info@seanroberts.ca"},
            new CourseStudent{id = 63, CourseIdjq = 108, StudentIdjq= 201 , FirstNamejq  = "Sean 2", LastNamejq = "Roberts2", Emailjq  = "info@google.ca"},
            new CourseStudent{id = 64, CourseIdjq = 108, StudentIdjq= 202 , FirstNamejq  = "Sean 3", LastNamejq = "Roberts3", Emailjq  = "info@yahoo.ca"},
            new CourseStudent{id = 65, CourseIdjq = 108, StudentIdjq= 203 , FirstNamejq  = "Sean 4", LastNamejq = "Roberts4", Emailjq  = "info@facebook.ca"},
            new CourseStudent{id = 66, CourseIdjq = 108, StudentIdjq= 204 , FirstNamejq  = "Sean 5", LastNamejq = "Roberts5", Emailjq  = "info@apple.ca"},
            new CourseStudent{id = 67, CourseIdjq = 108, StudentIdjq= 205 , FirstNamejq  = "Sean 6", LastNamejq = "Roberts6", Emailjq  = "info@bing.ca"},
            new CourseStudent{id = 68, CourseIdjq = 108, StudentIdjq= 206 , FirstNamejq  = "Sean 7", LastNamejq = "Roberts7", Emailjq  = "info@yelp.ca"},
            new CourseStudent{id = 69, CourseIdjq = 109, StudentIdjq= 200 , FirstNamejq  = "Sean 1", LastNamejq = "Roberts1", Emailjq  = "info@seanroberts.ca"},
            new CourseStudent{id = 70, CourseIdjq = 109, StudentIdjq= 201 , FirstNamejq  = "Sean 2", LastNamejq = "Roberts2", Emailjq  = "info@google.ca"},
            new CourseStudent{id = 71, CourseIdjq = 109, StudentIdjq= 202 , FirstNamejq  = "Sean 3", LastNamejq = "Roberts3", Emailjq  = "info@yahoo.ca"},
            new CourseStudent{id = 72, CourseIdjq = 109, StudentIdjq= 203 , FirstNamejq  = "Sean 4", LastNamejq = "Roberts4", Emailjq  = "info@facebook.ca"},
            new CourseStudent{id = 73, CourseIdjq = 109, StudentIdjq= 204 , FirstNamejq  = "Sean 5", LastNamejq = "Roberts5", Emailjq  = "info@apple.ca"},
            new CourseStudent{id = 74, CourseIdjq = 109, StudentIdjq= 205 , FirstNamejq  = "Sean 6", LastNamejq = "Roberts6", Emailjq  = "info@bing.ca"},
            new CourseStudent{id = 75, CourseIdjq = 109, StudentIdjq= 206 , FirstNamejq  = "Sean 7", LastNamejq = "Roberts7", Emailjq  = "info@yelp.ca"},
            new CourseStudent{id = 76, CourseIdjq = 110, StudentIdjq= 200 , FirstNamejq  = "Sean 1", LastNamejq = "Roberts1", Emailjq  = "info@seanroberts.ca"},
            new CourseStudent{id = 77, CourseIdjq = 110, StudentIdjq= 201 , FirstNamejq  = "Sean 2", LastNamejq = "Roberts2", Emailjq  = "info@google.ca"},
            new CourseStudent{id = 78, CourseIdjq = 110, StudentIdjq= 202 , FirstNamejq  = "Sean 3", LastNamejq = "Roberts3", Emailjq  = "info@yahoo.ca"},
            new CourseStudent{id = 79, CourseIdjq = 110, StudentIdjq= 203 , FirstNamejq  = "Sean 4", LastNamejq = "Roberts4", Emailjq  = "info@facebook.ca"},
            new CourseStudent{id = 80, CourseIdjq = 110, StudentIdjq= 204 , FirstNamejq  = "Sean 5", LastNamejq = "Roberts5", Emailjq  = "info@apple.ca"},
            new CourseStudent{id = 81, CourseIdjq = 110, StudentIdjq= 205 , FirstNamejq  = "Sean 6", LastNamejq = "Roberts6", Emailjq  = "info@bing.ca"},
            new CourseStudent{id = 82, CourseIdjq = 110, StudentIdjq= 206 , FirstNamejq  = "Sean 7", LastNamejq = "Roberts7", Emailjq  = "info@yelp.ca"}
        };


        public IEnumerable<CourseStudent> GetAll()
        {
            return _courseStudents;
        }
        public CourseStudent GetByCourseId(int id)
        {
            var courseStudent = _courseStudents.Where(i => i.CourseIdjq == id).FirstOrDefault();

            return courseStudent;
        }

    }
}
