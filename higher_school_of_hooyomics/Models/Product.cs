using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace higher_school_of_hooyomics.Models
{
    public class Product
    {
        public string Author { get; set; }

        public string Country { get; set; }

        public Uri ImageLink { get; set; }

        public string Language { get; set; }

        public int Pages { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public override string ToString() => "";
    }
}
