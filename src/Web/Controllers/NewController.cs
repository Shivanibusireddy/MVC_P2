using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace web.Controllers
{
    public class NewController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
         public IActionResult ShowText()
    {
      return Content("Here is text page ");
    }
    public IActionResult ShowJSON()
    {
      return  Json(new {name="shivani", message="Hello! This is Json "});
    }
    public IActionResult ShowHTML()
    {
      var h = "<!DOCTYPE html><html><body>This is a new controller." + 
      "<br><br> <a href='/New'>Go Back to New Page</a></body></html>";
      return Content(h, "text/html");
    }
        public IActionResult CalculateOdd()
        {
            return View("/Views/New/CalculateOdd.cshtml");
        }

    }
}
