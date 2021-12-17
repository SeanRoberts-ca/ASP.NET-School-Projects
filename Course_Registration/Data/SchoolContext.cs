using Course_Registration.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Registration.Data
{
    public class SchoolContext : DbContext
    {

     public SchoolContext(DbContextOptions<SchoolContext> options)
        : base(options) { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseStudent> CourseStudents { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Student { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //-------------
            modelBuilder.Entity<Course>().HasData(
            new Course { CourseId = 100, CourseNumber = 1, CourseName = "Introduction to IT", Description = "This course develops a basic understanding and competence in Information and Communications Technology. Students will gain awareness of hardware, software, and fundamental programming principles, along with hands on experience in problem solving using pseudo code and flowcharts. Assignments are designed to provide students with practical experience in solving problems in a structured manner." },
            new Course { CourseId = 101, CourseNumber = 2, CourseName = "Structured Programming in Java", Description = "This course is intended for students with no prior knowledge in programming. It provides an introduction to the development of solutions in Java using procedural techniques.It explores standard Java programming structures, including constants, variables, assignment statements, conditional logic, looping, functions, and user input/output methods to develop solutions in Java." },
            new Course { CourseId = 102, CourseNumber = 3, CourseName = "Object Oriented Programming", Description = "This course introduces students to the basic concepts of object-oriented programming in Java, focusing on the definition and use of classes along with the fundamentals of object-oriented design and programming techniques.Other topics include Unified Modelling Language(UML), arrays, analysis of algorithms, basic searching and sorting techniques, and memory management." },
            new Course { CourseId = 103, CourseNumber = 4, CourseName = "Inheritance and Polymorphism", Description = "A continuation of Object-Oriented Programming in Java, this course provides a deeper examination of object-oriented programming through Inheritance and Polymorphism. Issues related to program design, modularization, and code reuse will be emphasized." },
            new Course { CourseId = 104, CourseNumber = 5, CourseName = "Relational Databases and SQL", Description = "This course covers the fundamentals of relational database systems.Topics to be examined include database requirements, Entity Relationship modelling, database design, and Structured Query Language(SQL). Emphasis will be placed on data retrieval and manipulation techniques required in web applications." },
            new Course { CourseId = 105, CourseNumber = 6, CourseName = "Web Development Basics", Description = "This fundamental course in web development introduces students to HTML, CSS, and JavaScript.It employs a problem-based approach which requires the student to design and create a website of ever-increasing complexity as the course progresses." },
            new Course { CourseId = 106, CourseNumber = 7, CourseName = "Business Communications", Description = "This course provides students with the knowledge and tools to communicate effectively and professionally in the workplace.Students will be introduced to essential skills in writing, speaking, formal presentations and the use of technology to enhance workplace communication." },
            new Course { CourseId = 107, CourseNumber = 8, CourseName = "Career Preparation", Description = "In this course, students will be introduced to strategies for a successful job search, interview and career management. In the current competitive job search environment, it is essential for students to understand who they are, the skills they offer, what to expect from professional employment, and what employers expect of them." },
            new Course { CourseId = 108, CourseNumber = 9, CourseName = "Version Control with Github", Description = "The Version Control with Git and Github course provides students with a comprehensive, hands-on foundation of the Git version control system.Effective use of version control is an important and useful skill for any developer working on multi-developer projects." },
            new Course { CourseId = 109, CourseNumber = 12, CourseName = "ASP.NET Core", Description = "This course is intended for programmers with experience in C# who are interested in developing, and further enhancing, the skills necessary to build dynamic web applications running in the Cloud. The focus of the course is on creating applications with ASP.NET Core in order to build full stack Single Page Applications and REST APIs.This course prepares students for the Certified Tester" },
            new Course { CourseId = 110, CourseNumber = 13, CourseName = "Front End Frameworks", Description = "Students will learn to develop dynamic Single Page Web Applications using three of today’s most popular front-end frameworks: Angular, React, and Vue.Through a series of graduated assignments, students will develop an application called The Everyday Market App in each of the three frameworks.The Everyday Market App contains all the components of a standard shopping cart app" }
            );
            //-------------
            modelBuilder.Entity<CourseStudent>().HasData(
            new CourseStudent { id = 1, CourseIdjq = 100, StudentIdjq = 200, FirstNamejq = "Sean 1", LastNamejq = "Roberts1", Emailjq = "info@seanroberts.ca" },
            new CourseStudent { id = 2, CourseIdjq = 100, StudentIdjq = 201, FirstNamejq = "Sean 2", LastNamejq = "Roberts2", Emailjq = "info@google.ca" },
            new CourseStudent { id = 3, CourseIdjq = 100, StudentIdjq = 202, FirstNamejq = "Sean 3", LastNamejq = "Roberts3", Emailjq = "info@yahoo.ca" },
            new CourseStudent { id = 4, CourseIdjq = 100, StudentIdjq = 203, FirstNamejq = "Sean 4", LastNamejq = "Roberts4", Emailjq = "info@facebook.ca" },
            new CourseStudent { id = 5, CourseIdjq = 100, StudentIdjq = 204, FirstNamejq = "Sean 5", LastNamejq = "Roberts5", Emailjq = "info@apple.ca" },
            new CourseStudent { id = 6, CourseIdjq = 100, StudentIdjq = 205, FirstNamejq = "Sean 6", LastNamejq = "Roberts6", Emailjq = "info@bing.ca" },
            new CourseStudent { id = 7, CourseIdjq = 100, StudentIdjq = 206, FirstNamejq = "Sean 7", LastNamejq = "Roberts7", Emailjq = "info@yelp.ca" },
            new CourseStudent { id = 8, CourseIdjq = 100, StudentIdjq = 207, FirstNamejq = "Sean 8", LastNamejq = "Roberts8", Emailjq = "info@mysite.ca" },
            new CourseStudent { id = 9, CourseIdjq = 100, StudentIdjq = 208, FirstNamejq = "Sean 9", LastNamejq = "Roberts9", Emailjq = "info@newssite.ca" },
            new CourseStudent { id = 10, CourseIdjq = 100, StudentIdjq = 209, FirstNamejq = "Sean 10", LastNamejq = "Roberts10", Emailjq = "info@design.ca" },
            new CourseStudent { id = 11, CourseIdjq = 100, StudentIdjq = 200, FirstNamejq = "Sean 1", LastNamejq = "Roberts1", Emailjq = "info@seanroberts.ca" },
            new CourseStudent { id = 12, CourseIdjq = 101, StudentIdjq = 201, FirstNamejq = "Sean 2", LastNamejq = "Roberts2", Emailjq = "info@google.ca" },
            new CourseStudent { id = 13, CourseIdjq = 101, StudentIdjq = 202, FirstNamejq = "Sean 3", LastNamejq = "Roberts3", Emailjq = "info@yahoo.ca" },
            new CourseStudent { id = 14, CourseIdjq = 101, StudentIdjq = 203, FirstNamejq = "Sean 4", LastNamejq = "Roberts4", Emailjq = "info@facebook.ca" },
            new CourseStudent { id = 15, CourseIdjq = 101, StudentIdjq = 204, FirstNamejq = "Sean 5", LastNamejq = "Roberts5", Emailjq = "info@apple.ca" },
            new CourseStudent { id = 16, CourseIdjq = 101, StudentIdjq = 205, FirstNamejq = "Sean 6", LastNamejq = "Roberts6", Emailjq = "info@bing.ca" },
            new CourseStudent { id = 17, CourseIdjq = 101, StudentIdjq = 206, FirstNamejq = "Sean 7", LastNamejq = "Roberts7", Emailjq = "info@yelp.ca" },
            new CourseStudent { id = 18, CourseIdjq = 101, StudentIdjq = 207, FirstNamejq = "Sean 8", LastNamejq = "Roberts8", Emailjq = "info@mysite.ca" },
            new CourseStudent { id = 19, CourseIdjq = 101, StudentIdjq = 208, FirstNamejq = "Sean 9", LastNamejq = "Roberts9", Emailjq = "info@newssite.ca" },
            new CourseStudent { id = 20, CourseIdjq = 101, StudentIdjq = 209, FirstNamejq = "Sean 10", LastNamejq = "Roberts10", Emailjq = "info@design.ca" },
            new CourseStudent { id = 21, CourseIdjq = 102, StudentIdjq = 201, FirstNamejq = "Sean 2", LastNamejq = "Roberts2", Emailjq = "info@google.ca" },
            new CourseStudent { id = 22, CourseIdjq = 102, StudentIdjq = 202, FirstNamejq = "Sean 3", LastNamejq = "Roberts3", Emailjq = "info@yahoo.ca" },
            new CourseStudent { id = 23, CourseIdjq = 102, StudentIdjq = 203, FirstNamejq = "Sean 4", LastNamejq = "Roberts4", Emailjq = "info@facebook.ca" },
            new CourseStudent { id = 24, CourseIdjq = 102, StudentIdjq = 204, FirstNamejq = "Sean 5", LastNamejq = "Roberts5", Emailjq = "info@apple.ca" },
            new CourseStudent { id = 25, CourseIdjq = 102, StudentIdjq = 205, FirstNamejq = "Sean 6", LastNamejq = "Roberts6", Emailjq = "info@bing.ca" },
            new CourseStudent { id = 26, CourseIdjq = 102, StudentIdjq = 206, FirstNamejq = "Sean 7", LastNamejq = "Roberts7", Emailjq = "info@yelp.ca" },
            new CourseStudent { id = 27, CourseIdjq = 102, StudentIdjq = 207, FirstNamejq = "Sean 8", LastNamejq = "Roberts8", Emailjq = "info@mysite.ca" },
            new CourseStudent { id = 28, CourseIdjq = 102, StudentIdjq = 208, FirstNamejq = "Sean 9", LastNamejq = "Roberts9", Emailjq = "info@newssite.ca" },
            new CourseStudent { id = 29, CourseIdjq = 102, StudentIdjq = 209, FirstNamejq = "Sean 10", LastNamejq = "Roberts10", Emailjq = "info@design.ca" },
            new CourseStudent { id = 30, CourseIdjq = 103, StudentIdjq = 204, FirstNamejq = "Sean 5", LastNamejq = "Roberts5", Emailjq = "info@apple.ca" },
            new CourseStudent { id = 31, CourseIdjq = 103, StudentIdjq = 205, FirstNamejq = "Sean 6", LastNamejq = "Roberts6", Emailjq = "info@bing.ca" },
            new CourseStudent { id = 32, CourseIdjq = 103, StudentIdjq = 206, FirstNamejq = "Sean 7", LastNamejq = "Roberts7", Emailjq = "info@yelp.ca" },
            new CourseStudent { id = 33, CourseIdjq = 103, StudentIdjq = 207, FirstNamejq = "Sean 8", LastNamejq = "Roberts8", Emailjq = "info@mysite.ca" },
            new CourseStudent { id = 34, CourseIdjq = 103, StudentIdjq = 208, FirstNamejq = "Sean 9", LastNamejq = "Roberts9", Emailjq = "info@newssite.ca" },
            new CourseStudent { id = 35, CourseIdjq = 103, StudentIdjq = 209, FirstNamejq = "Sean 10", LastNamejq = "Roberts10", Emailjq = "info@design.ca" },
            new CourseStudent { id = 36, CourseIdjq = 104, StudentIdjq = 204, FirstNamejq = "Sean 5", LastNamejq = "Roberts5", Emailjq = "info@apple.ca" },
            new CourseStudent { id = 37, CourseIdjq = 104, StudentIdjq = 205, FirstNamejq = "Sean 6", LastNamejq = "Roberts6", Emailjq = "info@bing.ca" },
            new CourseStudent { id = 38, CourseIdjq = 104, StudentIdjq = 206, FirstNamejq = "Sean 7", LastNamejq = "Roberts7", Emailjq = "info@yelp.ca" },
            new CourseStudent { id = 39, CourseIdjq = 104, StudentIdjq = 207, FirstNamejq = "Sean 8", LastNamejq = "Roberts8", Emailjq = "info@mysite.ca" },
            new CourseStudent { id = 40, CourseIdjq = 104, StudentIdjq = 208, FirstNamejq = "Sean 9", LastNamejq = "Roberts9", Emailjq = "info@newssite.ca" },
            new CourseStudent { id = 41, CourseIdjq = 104, StudentIdjq = 209, FirstNamejq = "Sean 10", LastNamejq = "Roberts10", Emailjq = "info@design.ca" },
            new CourseStudent { id = 42, CourseIdjq = 105, StudentIdjq = 204, FirstNamejq = "Sean 5", LastNamejq = "Roberts5", Emailjq = "info@apple.ca" },
            new CourseStudent { id = 43, CourseIdjq = 105, StudentIdjq = 205, FirstNamejq = "Sean 6", LastNamejq = "Roberts6", Emailjq = "info@bing.ca" },
            new CourseStudent { id = 44, CourseIdjq = 105, StudentIdjq = 206, FirstNamejq = "Sean 7", LastNamejq = "Roberts7", Emailjq = "info@yelp.ca" },
            new CourseStudent { id = 45, CourseIdjq = 105, StudentIdjq = 207, FirstNamejq = "Sean 8", LastNamejq = "Roberts8", Emailjq = "info@mysite.ca" },
            new CourseStudent { id = 46, CourseIdjq = 105, StudentIdjq = 208, FirstNamejq = "Sean 9", LastNamejq = "Roberts9", Emailjq = "info@newssite.ca" },
            new CourseStudent { id = 47, CourseIdjq = 105, StudentIdjq = 209, FirstNamejq = "Sean 10", LastNamejq = "Roberts10", Emailjq = "info@design.ca" },
            new CourseStudent { id = 48, CourseIdjq = 106, StudentIdjq = 200, FirstNamejq = "Sean 1", LastNamejq = "Roberts1", Emailjq = "info@seanroberts.ca" },
            new CourseStudent { id = 49, CourseIdjq = 106, StudentIdjq = 201, FirstNamejq = "Sean 2", LastNamejq = "Roberts2", Emailjq = "info@google.ca" },
            new CourseStudent { id = 50, CourseIdjq = 106, StudentIdjq = 202, FirstNamejq = "Sean 3", LastNamejq = "Roberts3", Emailjq = "info@yahoo.ca" },
            new CourseStudent { id = 51, CourseIdjq = 106, StudentIdjq = 203, FirstNamejq = "Sean 4", LastNamejq = "Roberts4", Emailjq = "info@facebook.ca" },
            new CourseStudent { id = 52, CourseIdjq = 106, StudentIdjq = 204, FirstNamejq = "Sean 5", LastNamejq = "Roberts5", Emailjq = "info@apple.ca" },
            new CourseStudent { id = 53, CourseIdjq = 106, StudentIdjq = 205, FirstNamejq = "Sean 6", LastNamejq = "Roberts6", Emailjq = "info@bing.ca" },
            new CourseStudent { id = 54, CourseIdjq = 106, StudentIdjq = 206, FirstNamejq = "Sean 7", LastNamejq = "Roberts7", Emailjq = "info@yelp.ca" },
            new CourseStudent { id = 55, CourseIdjq = 107, StudentIdjq = 200, FirstNamejq = "Sean 1", LastNamejq = "Roberts1", Emailjq = "info@seanroberts.ca" },
            new CourseStudent { id = 56, CourseIdjq = 107, StudentIdjq = 201, FirstNamejq = "Sean 2", LastNamejq = "Roberts2", Emailjq = "info@google.ca" },
            new CourseStudent { id = 57, CourseIdjq = 107, StudentIdjq = 202, FirstNamejq = "Sean 3", LastNamejq = "Roberts3", Emailjq = "info@yahoo.ca" },
            new CourseStudent { id = 58, CourseIdjq = 107, StudentIdjq = 203, FirstNamejq = "Sean 4", LastNamejq = "Roberts4", Emailjq = "info@facebook.ca" },
            new CourseStudent { id = 59, CourseIdjq = 107, StudentIdjq = 204, FirstNamejq = "Sean 5", LastNamejq = "Roberts5", Emailjq = "info@apple.ca" },
            new CourseStudent { id = 60, CourseIdjq = 107, StudentIdjq = 205, FirstNamejq = "Sean 6", LastNamejq = "Roberts6", Emailjq = "info@bing.ca" },
            new CourseStudent { id = 61, CourseIdjq = 107, StudentIdjq = 206, FirstNamejq = "Sean 7", LastNamejq = "Roberts7", Emailjq = "info@yelp.ca" },
            new CourseStudent { id = 62, CourseIdjq = 108, StudentIdjq = 200, FirstNamejq = "Sean 1", LastNamejq = "Roberts1", Emailjq = "info@seanroberts.ca" },
            new CourseStudent { id = 63, CourseIdjq = 108, StudentIdjq = 201, FirstNamejq = "Sean 2", LastNamejq = "Roberts2", Emailjq = "info@google.ca" },
            new CourseStudent { id = 64, CourseIdjq = 108, StudentIdjq = 202, FirstNamejq = "Sean 3", LastNamejq = "Roberts3", Emailjq = "info@yahoo.ca" },
            new CourseStudent { id = 65, CourseIdjq = 108, StudentIdjq = 203, FirstNamejq = "Sean 4", LastNamejq = "Roberts4", Emailjq = "info@facebook.ca" },
            new CourseStudent { id = 66, CourseIdjq = 108, StudentIdjq = 204, FirstNamejq = "Sean 5", LastNamejq = "Roberts5", Emailjq = "info@apple.ca" },
            new CourseStudent { id = 67, CourseIdjq = 108, StudentIdjq = 205, FirstNamejq = "Sean 6", LastNamejq = "Roberts6", Emailjq = "info@bing.ca" },
            new CourseStudent { id = 68, CourseIdjq = 108, StudentIdjq = 206, FirstNamejq = "Sean 7", LastNamejq = "Roberts7", Emailjq = "info@yelp.ca" },
            new CourseStudent { id = 69, CourseIdjq = 109, StudentIdjq = 200, FirstNamejq = "Sean 1", LastNamejq = "Roberts1", Emailjq = "info@seanroberts.ca" },
            new CourseStudent { id = 70, CourseIdjq = 109, StudentIdjq = 201, FirstNamejq = "Sean 2", LastNamejq = "Roberts2", Emailjq = "info@google.ca" },
            new CourseStudent { id = 71, CourseIdjq = 109, StudentIdjq = 202, FirstNamejq = "Sean 3", LastNamejq = "Roberts3", Emailjq = "info@yahoo.ca" },
            new CourseStudent { id = 72, CourseIdjq = 109, StudentIdjq = 203, FirstNamejq = "Sean 4", LastNamejq = "Roberts4", Emailjq = "info@facebook.ca" },
            new CourseStudent { id = 73, CourseIdjq = 109, StudentIdjq = 204, FirstNamejq = "Sean 5", LastNamejq = "Roberts5", Emailjq = "info@apple.ca" },
            new CourseStudent { id = 74, CourseIdjq = 109, StudentIdjq = 205, FirstNamejq = "Sean 6", LastNamejq = "Roberts6", Emailjq = "info@bing.ca" },
            new CourseStudent { id = 75, CourseIdjq = 109, StudentIdjq = 206, FirstNamejq = "Sean 7", LastNamejq = "Roberts7", Emailjq = "info@yelp.ca" },
            new CourseStudent { id = 76, CourseIdjq = 110, StudentIdjq = 200, FirstNamejq = "Sean 1", LastNamejq = "Roberts1", Emailjq = "info@seanroberts.ca" },
            new CourseStudent { id = 77, CourseIdjq = 110, StudentIdjq = 201, FirstNamejq = "Sean 2", LastNamejq = "Roberts2", Emailjq = "info@google.ca" },
            new CourseStudent { id = 78, CourseIdjq = 110, StudentIdjq = 202, FirstNamejq = "Sean 3", LastNamejq = "Roberts3", Emailjq = "info@yahoo.ca" },
            new CourseStudent { id = 79, CourseIdjq = 110, StudentIdjq = 203, FirstNamejq = "Sean 4", LastNamejq = "Roberts4", Emailjq = "info@facebook.ca" },
            new CourseStudent { id = 80, CourseIdjq = 110, StudentIdjq = 204, FirstNamejq = "Sean 5", LastNamejq = "Roberts5", Emailjq = "info@apple.ca" },
            new CourseStudent { id = 81, CourseIdjq = 110, StudentIdjq = 205, FirstNamejq = "Sean 6", LastNamejq = "Roberts6", Emailjq = "info@bing.ca" },
            new CourseStudent { id = 82, CourseIdjq = 110, StudentIdjq = 206, FirstNamejq = "Sean 7", LastNamejq = "Roberts7", Emailjq = "info@yelp.ca" }
            );
            //-------------
            modelBuilder.Entity<Instructor>().HasData(
            new Instructor { Id = 10000, CourseId = 100, FirstName = "Teacher 1", LastName = "Jones 1", Email = "david1@yahoo.com" },
            new Instructor { Id = 10001, CourseId = 101, FirstName = "Teacher 2", LastName = "Jones 2", Email = "david2@yahoo.com" },
            new Instructor { Id = 10002, CourseId = 102, FirstName = "Teacher 3", LastName = "Jones 3", Email = "david3@yahoo.com" },
            new Instructor { Id = 10003, CourseId = 103, FirstName = "Teacher 4", LastName = "Jones 4", Email = "david4@yahoo.com" },
            new Instructor { Id = 10004, CourseId = 104, FirstName = "Teacher 5", LastName = "Jones 5", Email = "david5@yahoo.com" },
            new Instructor { Id = 10005, CourseId = 105, FirstName = "Teacher 6", LastName = "Jones 6", Email = "david6@yahoo.com" },
            new Instructor { Id = 10006, CourseId = 106, FirstName = "Teacher 7", LastName = "Jones 7", Email = "david7@yahoo.com" },
            new Instructor { Id = 10007, CourseId = 107, FirstName = "Teacher 8", LastName = "Jones 8", Email = "david8@yahoo.com" },
            new Instructor { Id = 10008, CourseId = 108, FirstName = "Teacher 9", LastName = "Jones 9", Email = "david9@yahoo.com" },
            new Instructor { Id = 10009, CourseId = 109, FirstName = "Teacher 10", LastName = "Jones 10", Email = "david10@yahoo.com" },
            new Instructor { Id = 10010, CourseId = 110, FirstName = "Teacher 11", LastName = "Jones 11", Email = "david11@yahoo.com" }
            );
            //-------------
            modelBuilder.Entity<Student>().HasData(
            new Student { StudentId = 200, FirstName = "Sean 1", LastName = "Roberts1", Email = "info@seanroberts.ca", PhoneNumber = "204-899-1142" },
            new Student { StudentId = 201, FirstName = "Sean 2", LastName = "Roberts2", Email = "info@google.ca", PhoneNumber = "204-999-2142" },
            new Student { StudentId = 202, FirstName = "Sean 3", LastName = "Roberts3", Email = "info@yahoo.ca", PhoneNumber = "204-301-3142" },
            new Student { StudentId = 203, FirstName = "Sean 4", LastName = "Roberts4", Email = "info@facebook.ca", PhoneNumber = "204-733-4142" },
            new Student { StudentId = 204, FirstName = "Sean 5", LastName = "Roberts5", Email = "info@apple.ca", PhoneNumber = "204-541-5142" },
            new Student { StudentId = 205, FirstName = "Sean 6", LastName = "Roberts6", Email = "info@bing.ca", PhoneNumber = "204-598-6142" },
            new Student { StudentId = 206, FirstName = "Sean 7", LastName = "Roberts7", Email = "info@yelp.ca", PhoneNumber = "204-321-7142" },
            new Student { StudentId = 207, FirstName = "Sean 8", LastName = "Roberts8", Email = "info@mysite.ca", PhoneNumber = "204-852-8142" },
            new Student { StudentId = 208, FirstName = "Sean 9", LastName = "Roberts9", Email = "info@newssite.ca", PhoneNumber = "204-789-9142" },
            new Student { StudentId = 209, FirstName = "Sean 10", LastName = "Roberts10", Email = "info@design.ca", PhoneNumber = "897-899-3142" }
            );
            //-------------
        }




        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=SchoolReg;Trusted_Connection=True;");
        //}
    }
}
