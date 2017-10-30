using System;

namespace quotingDojo2.Models 
{
    public class Meta
    {
        public int id { get; set; }
        public string metatext { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}