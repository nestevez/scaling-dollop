using System;
using System.Collections.Generic;

namespace quotingDojo2.Models
{
    public class Author
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public List<Quote> Quotes { get; set; }

        public Author() 
        {
            Quotes = new List<Quote>();
        }
    }
}