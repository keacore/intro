<a name="Exercise2" ></a>
# Exercise 2: Introduction to Routing & MVC #

A route is a URL pattern that is mapped to a handler. The handler can be a physical file, such as an .aspx file in a Web Forms application. A handler can also be a class that processes the request, such as a controller in an MVC application.

ASP.NET Core routing enables you to use URLs that do not have to map to specific files in a Web site. Because the URL does not have to map to a file, you can use URLs that are descriptive of the user's action and therefore are more easily understood by users.

In this exercise, you'll learn how to configure routing in your application.

<a name="Ex2Task1" ></a>
## Task 1 - Adding MVC ##

ASP.NET Core MVC gives you a powerful, patterns-based way to build dynamic websites that enables a clean separation of concerns and that gives you full control over markup for enjoyable, agile development. ASP.NET MVC includes many features that enable fast, TDD-friendly development for creating sophisticated applications that use the latest web standards.

In this task, you'll configure the project to use ASP.NET Core MVC and configure a sample route.

1. Continue with the solution that you obtained in the previous [exercise](/blob/master/Exercise1.md).

1. Open the **project.json** file and add **Microsoft.AspNetCore.Mvc** to the **dependencies** section.

	````JSON
	"dependencies": {
		"Microsoft.AspNetCore.Server.Kestrel": "1.0.1",
    	"Microsoft.AspNetCore.StaticFiles": "1.0.0",
		"Microsoft.AspNetCore.Mvc": "6.0.0-rc1-final"
	},
	````

1. **Add** a New Folder and name the folder _Controllers_.

1. **Add** a new file and name the file _HomeController.cs_.

1. Add the following code snippet.

	````C#
	namespace ConsoleApplication
	{
		 using Microsoft.AspNet.Mvc;

		 public class HomeController : Controller
		 {
			  [HttpGet()]
			  public string Index() => "Hello from MVC!";
		 }
	}
	````

1. Now, open the **Startup.cs** file and add the MVC services and middleware to the configuration, adding `services.AddMvc()` and replacing the `app.Run` method call in the **Configure** method with the `UseMvc` method as shown in the following code snippet.

	<!-- mark:3,13-18 -->
	````C#
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app)
    {
        app.UseIISPlatformHandler();

        app.UseFileServer();

        app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
    }
	````

1. Run the site and verify the message is returned from your MVC controller by navigating to the **/home** endpoint.

	> **Note:** ASP.NET Core MVC also includes a handy new utility method, `app.UseMvcWithDefaultRoute` so you don't have to remember that template string.