using System;
using System.Collections.Generic;

namespace quotingDojo2.Models
{
    public class Category
    {
        public int id { get; set; }
        public string catname { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public List<Categorized> Quotes { get; set; }
    }
}