using System;
using System.Collections.Generic;

namespace quotingDojo2.Models 
{
    public class Quote
    {
        public int id { get; set; }
        public string quote { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        // public int metasid { get; set; }
        // public Meta metas { get; set; }
        // public int authorsid { get; set; }
        // public Author authors { get; set; }
        // public List<Categorized> Categories { get; set; }

        public Quote()
        {
            // Categories = new List<Categorized>();
        }
    }
}