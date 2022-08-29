using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Assesment_7.Models
{
    [Table("Employee_Table")]
    public class Employee
    {
        [Key]

        public int EId { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [StringLength(40, ErrorMessage = "Length of Name Should not be More than 40 character")]
        [MinLength(3, ErrorMessage = "Name Should have Minimum 3 character")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Gender is Required")]
        [MinLength(3, ErrorMessage = "Dont use Abbreviation for Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "City is Required")]
        
        public string City { get; set; }

        [Required(ErrorMessage = "Salary Is Required")]
        
        public float Salary { get; set; }

        [Required(ErrorMessage="Department Id is Required")]

        public int DId { get; set; }
        public virtual ICollection<Department> Departments { get; set; }

    }
}