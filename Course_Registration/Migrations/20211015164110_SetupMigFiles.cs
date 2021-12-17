using Microsoft.EntityFrameworkCore.Migrations;

namespace Course_Registration.Migrations
{
    public partial class SetupMigFiles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseNumber = table.Column<int>(type: "int", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "CourseStudents",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseIdjq = table.Column<int>(type: "int", nullable: false),
                    StudentIdjq = table.Column<int>(type: "int", nullable: false),
                    FirstNamejq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastNamejq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emailjq = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudents", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "CourseStudents",
                columns: new[] { "id", "CourseIdjq", "Emailjq", "FirstNamejq", "LastNamejq", "StudentIdjq" },
                values: new object[,]
                {
                    { 46, 105, "info@newssite.ca", "Sean 9", "Roberts9", 208 },
                    { 48, 106, "info@seanroberts.ca", "Sean 1", "Roberts1", 200 },
                    { 47, 105, "info@design.ca", "Sean 10", "Roberts10", 209 },
                    { 72, 109, "info@facebook.ca", "Sean 4", "Roberts4", 203 },
                    { 45, 105, "info@mysite.ca", "Sean 8", "Roberts8", 207 },
                    { 44, 105, "info@yelp.ca", "Sean 7", "Roberts7", 206 },
                    { 43, 105, "info@bing.ca", "Sean 6", "Roberts6", 205 },
                    { 42, 105, "info@apple.ca", "Sean 5", "Roberts5", 204 },
                    { 49, 106, "info@google.ca", "Sean 2", "Roberts2", 201 },
                    { 41, 104, "info@design.ca", "Sean 10", "Roberts10", 209 },
                    { 39, 104, "info@mysite.ca", "Sean 8", "Roberts8", 207 },
                    { 38, 104, "info@yelp.ca", "Sean 7", "Roberts7", 206 },
                    { 37, 104, "info@bing.ca", "Sean 6", "Roberts6", 205 },
                    { 36, 104, "info@apple.ca", "Sean 5", "Roberts5", 204 },
                    { 35, 103, "info@design.ca", "Sean 10", "Roberts10", 209 },
                    { 34, 103, "info@newssite.ca", "Sean 9", "Roberts9", 208 },
                    { 33, 103, "info@mysite.ca", "Sean 8", "Roberts8", 207 },
                    { 40, 104, "info@newssite.ca", "Sean 9", "Roberts9", 208 },
                    { 50, 106, "info@yahoo.ca", "Sean 3", "Roberts3", 202 },
                    { 51, 106, "info@facebook.ca", "Sean 4", "Roberts4", 203 },
                    { 52, 106, "info@apple.ca", "Sean 5", "Roberts5", 204 },
                    { 69, 109, "info@seanroberts.ca", "Sean 1", "Roberts1", 200 },
                    { 68, 108, "info@yelp.ca", "Sean 7", "Roberts7", 206 },
                    { 67, 108, "info@bing.ca", "Sean 6", "Roberts6", 205 },
                    { 66, 108, "info@apple.ca", "Sean 5", "Roberts5", 204 },
                    { 65, 108, "info@facebook.ca", "Sean 4", "Roberts4", 203 },
                    { 64, 108, "info@yahoo.ca", "Sean 3", "Roberts3", 202 },
                    { 63, 108, "info@google.ca", "Sean 2", "Roberts2", 201 },
                    { 62, 108, "info@seanroberts.ca", "Sean 1", "Roberts1", 200 },
                    { 61, 107, "info@yelp.ca", "Sean 7", "Roberts7", 206 },
                    { 60, 107, "info@bing.ca", "Sean 6", "Roberts6", 205 },
                    { 59, 107, "info@apple.ca", "Sean 5", "Roberts5", 204 },
                    { 58, 107, "info@facebook.ca", "Sean 4", "Roberts4", 203 },
                    { 57, 107, "info@yahoo.ca", "Sean 3", "Roberts3", 202 },
                    { 56, 107, "info@google.ca", "Sean 2", "Roberts2", 201 },
                    { 55, 107, "info@seanroberts.ca", "Sean 1", "Roberts1", 200 },
                    { 54, 106, "info@yelp.ca", "Sean 7", "Roberts7", 206 },
                    { 53, 106, "info@bing.ca", "Sean 6", "Roberts6", 205 },
                    { 32, 103, "info@yelp.ca", "Sean 7", "Roberts7", 206 },
                    { 31, 103, "info@bing.ca", "Sean 6", "Roberts6", 205 },
                    { 30, 103, "info@apple.ca", "Sean 5", "Roberts5", 204 },
                    { 29, 102, "info@design.ca", "Sean 10", "Roberts10", 209 }
                });

            migrationBuilder.InsertData(
                table: "CourseStudents",
                columns: new[] { "id", "CourseIdjq", "Emailjq", "FirstNamejq", "LastNamejq", "StudentIdjq" },
                values: new object[,]
                {
                    { 7, 100, "info@yelp.ca", "Sean 7", "Roberts7", 206 },
                    { 6, 100, "info@bing.ca", "Sean 6", "Roberts6", 205 },
                    { 5, 100, "info@apple.ca", "Sean 5", "Roberts5", 204 },
                    { 4, 100, "info@facebook.ca", "Sean 4", "Roberts4", 203 },
                    { 3, 100, "info@yahoo.ca", "Sean 3", "Roberts3", 202 },
                    { 2, 100, "info@google.ca", "Sean 2", "Roberts2", 201 },
                    { 1, 100, "info@seanroberts.ca", "Sean 1", "Roberts1", 200 },
                    { 73, 109, "info@apple.ca", "Sean 5", "Roberts5", 204 },
                    { 74, 109, "info@bing.ca", "Sean 6", "Roberts6", 205 },
                    { 75, 109, "info@yelp.ca", "Sean 7", "Roberts7", 206 },
                    { 76, 110, "info@seanroberts.ca", "Sean 1", "Roberts1", 200 },
                    { 77, 110, "info@google.ca", "Sean 2", "Roberts2", 201 },
                    { 78, 110, "info@yahoo.ca", "Sean 3", "Roberts3", 202 },
                    { 79, 110, "info@facebook.ca", "Sean 4", "Roberts4", 203 },
                    { 80, 110, "info@apple.ca", "Sean 5", "Roberts5", 204 },
                    { 81, 110, "info@bing.ca", "Sean 6", "Roberts6", 205 },
                    { 82, 110, "info@yelp.ca", "Sean 7", "Roberts7", 206 },
                    { 8, 100, "info@mysite.ca", "Sean 8", "Roberts8", 207 },
                    { 70, 109, "info@google.ca", "Sean 2", "Roberts2", 201 },
                    { 9, 100, "info@newssite.ca", "Sean 9", "Roberts9", 208 },
                    { 11, 100, "info@seanroberts.ca", "Sean 1", "Roberts1", 200 },
                    { 28, 102, "info@newssite.ca", "Sean 9", "Roberts9", 208 },
                    { 27, 102, "info@mysite.ca", "Sean 8", "Roberts8", 207 },
                    { 26, 102, "info@yelp.ca", "Sean 7", "Roberts7", 206 },
                    { 25, 102, "info@bing.ca", "Sean 6", "Roberts6", 205 },
                    { 24, 102, "info@apple.ca", "Sean 5", "Roberts5", 204 },
                    { 23, 102, "info@facebook.ca", "Sean 4", "Roberts4", 203 },
                    { 22, 102, "info@yahoo.ca", "Sean 3", "Roberts3", 202 },
                    { 21, 102, "info@google.ca", "Sean 2", "Roberts2", 201 },
                    { 20, 101, "info@design.ca", "Sean 10", "Roberts10", 209 },
                    { 19, 101, "info@newssite.ca", "Sean 9", "Roberts9", 208 },
                    { 18, 101, "info@mysite.ca", "Sean 8", "Roberts8", 207 },
                    { 17, 101, "info@yelp.ca", "Sean 7", "Roberts7", 206 },
                    { 16, 101, "info@bing.ca", "Sean 6", "Roberts6", 205 },
                    { 15, 101, "info@apple.ca", "Sean 5", "Roberts5", 204 },
                    { 14, 101, "info@facebook.ca", "Sean 4", "Roberts4", 203 },
                    { 13, 101, "info@yahoo.ca", "Sean 3", "Roberts3", 202 },
                    { 12, 101, "info@google.ca", "Sean 2", "Roberts2", 201 },
                    { 10, 100, "info@design.ca", "Sean 10", "Roberts10", 209 },
                    { 71, 109, "info@yahoo.ca", "Sean 3", "Roberts3", 202 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName", "CourseNumber", "Description" },
                values: new object[,]
                {
                    { 100, "Introduction to IT", 1, "This course develops a basic understanding and competence in Information and Communications Technology. Students will gain awareness of hardware, software, and fundamental programming principles, along with hands on experience in problem solving using pseudo code and flowcharts. Assignments are designed to provide students with practical experience in solving problems in a structured manner." },
                    { 110, "Front End Frameworks", 13, "Students will learn to develop dynamic Single Page Web Applications using three of today’s most popular front-end frameworks: Angular, React, and Vue.Through a series of graduated assignments, students will develop an application called The Everyday Market App in each of the three frameworks.The Everyday Market App contains all the components of a standard shopping cart app" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName", "CourseNumber", "Description" },
                values: new object[,]
                {
                    { 109, "ASP.NET Core", 12, "This course is intended for programmers with experience in C# who are interested in developing, and further enhancing, the skills necessary to build dynamic web applications running in the Cloud. The focus of the course is on creating applications with ASP.NET Core in order to build full stack Single Page Applications and REST APIs.This course prepares students for the Certified Tester" },
                    { 108, "Version Control with Github", 9, "The Version Control with Git and Github course provides students with a comprehensive, hands-on foundation of the Git version control system.Effective use of version control is an important and useful skill for any developer working on multi-developer projects." },
                    { 107, "Career Preparation", 8, "In this course, students will be introduced to strategies for a successful job search, interview and career management. In the current competitive job search environment, it is essential for students to understand who they are, the skills they offer, what to expect from professional employment, and what employers expect of them." },
                    { 106, "Business Communications", 7, "This course provides students with the knowledge and tools to communicate effectively and professionally in the workplace.Students will be introduced to essential skills in writing, speaking, formal presentations and the use of technology to enhance workplace communication." },
                    { 105, "Web Development Basics", 6, "This fundamental course in web development introduces students to HTML, CSS, and JavaScript.It employs a problem-based approach which requires the student to design and create a website of ever-increasing complexity as the course progresses." },
                    { 104, "Relational Databases and SQL", 5, "This course covers the fundamentals of relational database systems.Topics to be examined include database requirements, Entity Relationship modelling, database design, and Structured Query Language(SQL). Emphasis will be placed on data retrieval and manipulation techniques required in web applications." },
                    { 103, "Inheritance and Polymorphism", 4, "A continuation of Object-Oriented Programming in Java, this course provides a deeper examination of object-oriented programming through Inheritance and Polymorphism. Issues related to program design, modularization, and code reuse will be emphasized." },
                    { 102, "Object Oriented Programming", 3, "This course introduces students to the basic concepts of object-oriented programming in Java, focusing on the definition and use of classes along with the fundamentals of object-oriented design and programming techniques.Other topics include Unified Modelling Language(UML), arrays, analysis of algorithms, basic searching and sorting techniques, and memory management." },
                    { 101, "Structured Programming in Java", 2, "This course is intended for students with no prior knowledge in programming. It provides an introduction to the development of solutions in Java using procedural techniques.It explores standard Java programming structures, including constants, variables, assignment statements, conditional logic, looping, functions, and user input/output methods to develop solutions in Java." }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 10010, 110, "david11@yahoo.com", "Teacher 11", "Jones 11" },
                    { 10009, 109, "david10@yahoo.com", "Teacher 10", "Jones 10" },
                    { 10008, 108, "david9@yahoo.com", "Teacher 9", "Jones 9" },
                    { 10007, 107, "david8@yahoo.com", "Teacher 8", "Jones 8" },
                    { 10006, 106, "david7@yahoo.com", "Teacher 7", "Jones 7" },
                    { 10005, 105, "david6@yahoo.com", "Teacher 6", "Jones 6" },
                    { 10004, 104, "david5@yahoo.com", "Teacher 5", "Jones 5" },
                    { 10003, 103, "david4@yahoo.com", "Teacher 4", "Jones 4" },
                    { 10002, 102, "david3@yahoo.com", "Teacher 3", "Jones 3" },
                    { 10001, 101, "david2@yahoo.com", "Teacher 2", "Jones 2" },
                    { 10000, 100, "david1@yahoo.com", "Teacher 1", "Jones 1" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "CourseId", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 200, 0, "info@seanroberts.ca", "Sean 1", "Roberts1", "204-899-1142" },
                    { 201, 0, "info@google.ca", "Sean 2", "Roberts2", "204-999-2142" },
                    { 202, 0, "info@yahoo.ca", "Sean 3", "Roberts3", "204-301-3142" },
                    { 203, 0, "info@facebook.ca", "Sean 4", "Roberts4", "204-733-4142" },
                    { 204, 0, "info@apple.ca", "Sean 5", "Roberts5", "204-541-5142" },
                    { 205, 0, "info@bing.ca", "Sean 6", "Roberts6", "204-598-6142" },
                    { 206, 0, "info@yelp.ca", "Sean 7", "Roberts7", "204-321-7142" },
                    { 207, 0, "info@mysite.ca", "Sean 8", "Roberts8", "204-852-8142" },
                    { 208, 0, "info@newssite.ca", "Sean 9", "Roberts9", "204-789-9142" },
                    { 209, 0, "info@design.ca", "Sean 10", "Roberts10", "897-899-3142" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "CourseStudents");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
