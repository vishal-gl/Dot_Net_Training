using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Practise.Models
{
    public class Custom
    {
        [Key]
        public int Cid { get; set; }
        [Required(ErrorMessage ="Not be empty")]
 
        public string Cname { get; set; }

        [Required(ErrorMessage = "Not be empty")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Caddress { get; set; }

        [ForeignKey("Prod")]
        [Required(ErrorMessage = "Not be empty")]
        public int Prods_Pid { get; set; }
        public virtual Prod Prod { get; set; }
    }
}