using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Registration.Models
{
    public class Course
    {
        [Key]
        [DisplayName("Code")]
        public int CourseId { get; set; }
        [DisplayName("Course Number")] 
        public int CourseNumber { get; set; }
        [DisplayName("Course Name")] 
        public string CourseName { get; set; }
        [DisplayName("Course Description")]
        public string Description {get; set;}

    }
}
