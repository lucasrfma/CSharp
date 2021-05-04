using System;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/
        // public IActionResult Welcome()
        // {
        //     return View();
        // }
        // public string Welcome(string name = "lucas", int numtimes = 1)
        // {
        //     string result = "";
        //     for(int i = 0; i < numtimes; ++i)
        //     {
        //         result = result + $"Hello, {name}\n";
        //     }
        //     return result;
        // }
        public string Welcome(string name = "lucas", int ID = 1)
        {
            string result = "";
            for(int i = 0; i < ID; ++i)
            {
                result = result + $"Hello, {name}\n";
            }
            return result;
        }
    }
}