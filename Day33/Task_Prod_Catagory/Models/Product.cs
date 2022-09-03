using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Prod_Catagory.Models
{
    public class Product
    {


        [Key]

        public int PId { get; set; }


        [Required(ErrorMessage = "Name is Required")]
        [StringLength(40, ErrorMessage = "Length of Name Should not be More than 40 character")]
        [MinLength(3, ErrorMessage = "Name Should have Minimum 3 character")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Price is Required")]

        public float Price { get; set; }






        
        [Required(ErrorMessage = "Category Id is Required")]
        public int CId { get; set; }








        public Category category { get; set; }

    }
}