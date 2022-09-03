using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practise_MVC.Models
{
    [Table("Student_Table")]
    public class Student
    {
        [Key]

        public int SId { get; set; }


        [Required(ErrorMessage = "Name is Required")]
        [StringLength(40, ErrorMessage = "Length of Name Should not be More than 40 character")]
        [MinLength(3, ErrorMessage = "Name Should have Minimum 3 character")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Address is Required")]
        [MinLength(3, ErrorMessage = "Address Should have Minimum 3 character")]
        public string Address { get; set; }


        [Required(ErrorMessage = "Date Of Birth Is Required")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }



        [Required(ErrorMessage = "Age Is Required")]
        [Range(3, 32, ErrorMessage = "Age Should be lie between 3 and 40")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Course Id is Required")]
        public int CourseId { get; set; }


        [Required(ErrorMessage = "Email is Required")]
        [MinLength(3, ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Password Is Required")]
        [MinLength(5, ErrorMessage = "Invalid Password")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Confirm Password Is Required")]
        [Compare("Password", ErrorMessage = "Password does NOT match")]
        public string CPassword { get; set; }


        public Course course { get; set; }





    }
}