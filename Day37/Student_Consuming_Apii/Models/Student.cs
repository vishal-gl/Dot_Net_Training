using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Student_Consuming_Apii.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Id Is Required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name Is Required")]
        [MinLength(3,ErrorMessage ="Name Should have more than 2 character")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age Is Required")]
        [Range(3,33,ErrorMessage ="Age must be lie between 3 and 33")]
        public Nullable<int> Age { get; set; }

        [Required(ErrorMessage = "Standard Is Required")]
        [Range(1, 12, ErrorMessage = "Stadard must be lie between 1 and 12")]
        public Nullable<int> Standard { get; set; }

        [Required(ErrorMessage = "City Is Required")]
        [DisplayName("Address")]
        public string City { get; set; }

        [Required(ErrorMessage = "Course Id Is Required")]
        public string CId { get; set; }
    }
}