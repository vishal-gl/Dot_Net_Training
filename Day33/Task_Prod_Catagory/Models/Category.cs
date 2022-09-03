using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Task_Prod_Catagory.Models
{
    public class Category
    {
        [Key]
        
        public int CId { get; set; }

       
        public string CategoryName { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}