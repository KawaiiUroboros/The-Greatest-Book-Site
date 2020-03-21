using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using higher_school_of_hooyomics.Services;
namespace higher_school_of_hooyomics.Controllers
{
    

    public class TextAnalyzerController : Controller
    {
        private readonly ITextAnalyzerService _textAnalyzerService;

        //В конструкторе контроллера происходит инъекция сервисов через их интерфейсы
        public TextAnalyzerController(ITextAnalyzerService textAnalyzerService)
        {
            _textAnalyzerService = textAnalyzerService;
        }
        public IActionResult Index()
        {

            return View();
        }
    }
}