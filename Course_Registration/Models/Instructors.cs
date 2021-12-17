using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Registration.Models
{
    public class Instructor
    {
        [Key]
        public int Id {get;set;}
        
        [DisplayName("Course Id")]
        [ForeignKey("Course")]
        public int CourseId {get;set;}
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName{ get; set; }
        public string Email { get; set; }
    }
}
