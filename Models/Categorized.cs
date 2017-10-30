using System;

namespace quotingDojo2.Models 
{
    public class Categorized
    {
        public int id { get; set; }
        public int quote_id { get; set; }
        public Quote Quote { get; set; }
        public int category_id { get; set; }
        public Category Category { get; set; }
    }
}