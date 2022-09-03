using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DisplayApi.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Pleas Enter a Valid Id")]
        public int Id { get; set; }

        [Required(ErrorMessage ="Enter a Name")]
        [MinLength(3,ErrorMessage ="Please Give Valid Name")]
        [DisplayName("My Name")]
        public string Name { get; set; }

        [Required]
        [Range(0,900000 ,ErrorMessage="Invalid Salary")]
        public string Salary { get; set; }

        [Required(ErrorMessage ="Please fill The Department Id")]
        [DisplayName("Dept_Id")]

        
        public string Dept_Id { get; set; }
    }
}