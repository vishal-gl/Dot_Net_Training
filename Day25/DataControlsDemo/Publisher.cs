using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataControlsDemo
{
    public class Publisher
    {

        public List<Author> GetAuthorsByState(string state)
        {
            List<Author> authors = new List<Author>();
            if (state == "washington")
            {
                authors.Add(new Author("Adam", "smith"));
                authors.Add(new Author("Bob", "Jones"));
                authors.Add(new Author("Fred", "Baker"));
                authors.Add(new Author("Bill", "Staples"));

            }
            return authors;
        }
    }
}