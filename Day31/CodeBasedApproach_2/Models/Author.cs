﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeBasedApproach_2.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public virtual ICollection<Book> Books { get;set; }
    }
}