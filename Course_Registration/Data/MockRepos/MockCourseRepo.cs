using System;
using Course_Registration.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace Course_Registration.Data.MockRepos
{
    public class MockCourseRepo : ICourseRepo
    {

        private static List<Course> _courses = new List<Course>
        {
            new Course{CourseId = 100 , CourseNumber = 1, CourseName = "Introduction to IT",                Description = "This course develops a basic understanding and competence in Information and Communications Technology. Students will gain awareness of hardware, software, and fundamental programming principles, along with hands on experience in problem solving using pseudo code and flowcharts. Assignments are designed to provide students with practical experience in solving problems in a structured manner."},
            new Course{CourseId = 101 , CourseNumber = 2, CourseName = "Structured Programming in Java",    Description = "This course is intended for students with no prior knowledge in programming. It provides an introduction to the development of solutions in Java using procedural techniques.It explores standard Java programming structures, including constants, variables, assignment statements, conditional logic, looping, functions, and user input/output methods to develop solutions in Java." },
            new Course{CourseId = 102 , CourseNumber = 3, CourseName = "Object Oriented Programming",       Description = "This course introduces students to the basic concepts of object-oriented programming in Java, focusing on the definition and use of classes along with the fundamentals of object-oriented design and programming techniques.Other topics include Unified Modelling Language(UML), arrays, analysis of algorithms, basic searching and sorting techniques, and memory management." },
            new Course{CourseId = 103 , CourseNumber = 4, CourseName = "Inheritance and Polymorphism",      Description = "A continuation of Object-Oriented Programming in Java, this course provides a deeper examination of object-oriented programming through Inheritance and Polymorphism. Issues related to program design, modularization, and code reuse will be emphasized." },
            new Course{CourseId = 104 , CourseNumber = 5, CourseName = "Relational Databases and SQL",      Description = "This course covers the fundamentals of relational database systems.Topics to be examined include database requirements, Entity Relationship modelling, database design, and Structured Query Language(SQL). Emphasis will be placed on data retrieval and manipulation techniques required in web applications." },
            new Course { CourseId = 105, CourseNumber = 6, CourseName = "Web Development Basics", Description = "This fundamental course in web development introduces students to HTML, CSS, and JavaScript.It employs a problem-based approach which requires the student to design and create a website of ever-increasing complexity as the course progresses." },
            new Course { CourseId = 106, CourseNumber = 7, CourseName = "Business Communications", Description = "This course provides students with the knowledge and tools to communicate effectively and professionally in the workplace.Students will be introduced to essential skills in writing, speaking, formal presentations and the use of technology to enhance workplace communication." },
            new Course { CourseId = 107, CourseNumber = 8, CourseName = "Career Preparation", Description = "In this course, students will be introduced to strategies for a successful job search, interview and career management. In the current competitive job search environment, it is essential for students to understand who they are, the skills they offer, what to expect from professional employment, and what employers expect of them." },
            new Course { CourseId = 108, CourseNumber = 9, CourseName = "Version Control with Github", Description = "The Version Control with Git and Github course provides students with a comprehensive, hands-on foundation of the Git version control system.Effective use of version control is an important and useful skill for any developer working on multi-developer projects." },
            new Course { CourseId = 109, CourseNumber = 12, CourseName = "ASP.NET Core", Description = "This course is intended for programmers with experience in C# who are interested in developing, and further enhancing, the skills necessary to build dynamic web applications running in the Cloud. The focus of the course is on creating applications with ASP.NET Core in order to build full stack Single Page Applications and REST APIs.This course prepares students for the Certified Tester" },
            new Course { CourseId = 110, CourseNumber = 13, CourseName = "Front End Frameworks", Description = "Students will learn to develop dynamic Single Page Web Applications using three of today’s most popular front-end frameworks: Angular, React, and Vue.Through a series of graduated assignments, students will develop an application called The Everyday Market App in each of the three frameworks.The Everyday Market App contains all the components of a standard shopping cart app" }


    };

        public void Create(Course course)
        {
            int codeCourseNumber = _courses.Max(c => c.CourseNumber) + 1;
            int codeCourseId = _courses.Max(c => c.CourseId) + 1;
            course.CourseNumber = codeCourseNumber;
            course.CourseId = codeCourseId;
            _courses.Add(course);
        }

        public IEnumerable<Course> GetAll()
        {
            return _courses;
        }

        public Course GetById(int id)
        {
            var course = _courses.Where(c => c.CourseId == id).FirstOrDefault();

            return course;
        }

    }
}