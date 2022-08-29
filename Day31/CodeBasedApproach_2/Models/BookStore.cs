using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeBasedApproach_2.Models
{
    public class BookStore:DbContext
    {
        public BookStore() : base("DefaultConnection")
        {

        }
        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }
    }
}