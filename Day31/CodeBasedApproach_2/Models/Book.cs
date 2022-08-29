using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeBasedApproach_2.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string title { get; set; }

        public int page { get; set; }

        public int Price { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}