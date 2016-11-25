namespace ConsoleApplication
	{
		 
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
		 {
			  [HttpGet()]
			  public string Index() => "Hello from MVC!";
		 }
	}