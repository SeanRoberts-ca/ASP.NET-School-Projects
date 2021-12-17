using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Registration.Models
{
    public class CourseStudent
    {
        [Key] 
        public int id { get; set; }
        [ForeignKey("Course")]
        public int CourseIdjq { get; set; }
        [ForeignKey("Student")]
        public int StudentIdjq { get; set; }
        public string FirstNamejq { get; set; }
        public string LastNamejq { get; set; }
        public string Emailjq { get; set; }

    }

}
