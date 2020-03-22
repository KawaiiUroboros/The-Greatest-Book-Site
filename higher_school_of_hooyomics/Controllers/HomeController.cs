using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using higher_school_of_hooyomics.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using higher_school_of_hooyomics.Models;
using higher_school_of_hooyomics.Views.Home;
namespace higher_school_of_hooyomics.Controllers
{
    public class HomeController : Controller
    {
        JsonFileProductService _JsonFileProductService;
        public HomeController(JsonFileProductService jsonFileProductService):base()
        {
            _JsonFileProductService = jsonFileProductService;
        }

    

        public IActionResult Index()
        {
            var model = new HomeViewModel() { Products = new List<Product>() { new Product() { Description = "dfg" } } }; //_JsonFileProductService.GetProducts() };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Where()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult Books()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
