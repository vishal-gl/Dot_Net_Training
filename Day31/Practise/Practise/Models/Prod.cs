using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practise.Models
{
    public class Prod
    {
        [Key]
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime Purchase { get; set; }
        public ICollection<Custom> Custom { get; set; }
    }
}