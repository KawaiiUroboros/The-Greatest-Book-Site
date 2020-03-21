using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContosoCrafts.WebSite.Services;
using higher_school_of_hooyomics.Models;
namespace higher_school_of_hooyomics.Views.Home
{
    public class IndexModel : PageModel
    {

        public JsonFileProductService ProductService { get; set; }
        public IEnumerable<Product> Products { get; private set; }
        public IndexModel(JsonFileProductService productService)
        {
            ProductService = productService;
        }
        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
