using Microsoft.AspNetCore.Mvc;

namespace ConsoleApplication
{
    public class HomeController : Controller
    {
        [HttpGet()]
        //public string Index() => "Hello from MVC!";
        public IActionResult Index()
        {
            return View();
        }
    }
}