using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Practise.Models
{
    public class ComContext:DbContext
    {
        public ComContext() : base("ComContext")
        {

        }
        public DbSet<Custom> Customs { get; set; }
        public DbSet<Prod> Prods { get; set; }
    }
}