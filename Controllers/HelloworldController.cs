using Microsoft.AspNetCore.Mvc;

namespace NNS0709.Controllers;

public class HelloWorldController : Controller
{
     public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Cập Nhật Thông Tin " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

}