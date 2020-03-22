using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace higher_school_of_hooyomics.Models
{
    public class Product
    {
        public string Author { get; set; }
        public string Country { get; set; }

        [JsonPropertyName("imageLink")]
        public string Image { get; set; }
        public string language { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public int Year { get; set; }
        public int[] Ratings { get; set; }
        public int Pages { get; set; }
        public List<string> Tags { get; set; }
        public override string ToString() => JsonSerializer.Serialize<Product>(this);


    }
}