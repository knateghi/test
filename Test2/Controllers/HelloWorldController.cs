using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Test2.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET: /HelloWorld
        public string Index()
        {
            return ("This is my default action...");
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }

}
