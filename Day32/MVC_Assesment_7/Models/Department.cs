using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Assesment_7.Models
{
    public class Department
    {
        [Key]
        public int DId { get; set; }


        [Required(ErrorMessage = "Name is Required")]
        [StringLength(30, ErrorMessage = "Length of Name Should not be More than 30 character")]
        [MinLength(2, ErrorMessage = "Name Should have Minimum 2 character")]
        public string DeptName { get; set; }

        public Employee employee { get; set; }

    }
}