<a name="Exercise1"></a>
# Exercise 1: Working with static files #

Static files, which include HTML files, CSS files, image files, and JavaScript files, are assets that the app will serve directly to clients.

In this exercise, you'll configure your project to serve static files.

<a name="Ex1Task1"></a>
#### Task 1 - Serving static files ####

In order for static files to be served, you must configure the _Middleware_ to add static files to the pipeline. This is accomplished by calling the **UseStaticFiles** extension method from **Startup.Configure** method.

In this task, you'll create an empty ASP.NET Core 1.0 project and configure it to serve static files.

1. Create a new .NET Core project:

````
mkdir aspnetcoreapp
cd aspnetcoreapp
dotnet new
````
2. Restore the packages:
````
dotnet restore
````
3. Run the app (the dotnet run command will build the app when it's out of date):
````
dotnet run
````
4. The Console should now show:
````
Hello World!
````

1. Add the **Microsoft.AspNet.Server.Kestrel** and the **Microsoft.AspNet.StaticFiles** package as a dependency to **project.json**.

	````JSON
	"dependencies": {
	  	"Microsoft.AspNetCore.Server.Kestrel": "1.0.1",
    	"Microsoft.AspNetCore.StaticFiles": "1.0.0"
	},
	````

2. Create a **WebHostBuilder()** in your **Main** Method in the **Program.cs** file

    ````C#

            public static void Main(string[] args)
            {

                var host = new WebHostBuilder()
                    .UseKestrel()
					.UseContentRoot(Directory.GetCurrentDirectory())
                    .UseStartup<Startup>()
                    .Build();

                host.Run();
            }

    ````
 

1. Create a **Startup.cs** file and add the middleware **UseStaticFiles** in the **Configure** method before the hello world middleware.

	<!-- mark:5 -->
	````C#
			using Microsoft.AspNetCore.Builder;
			using Microsoft.AspNetCore.Http;

			namespace ConsoleApplication
			{
				public class Startup
				{

					public void Configure(IApplicationBuilder app)
					{

						app.UseStaticFiles();

						app.Run(async (context) =>
						{
							await context.Response.WriteAsync("Hello World!");
						});
					}
				}

			}
	````

1. Create a folder called wwwroot and a file called **index.html** with the following contents in the **wwwroot** folder.

	<!-- mark:1-10 -->
	````HTML
	<!DOCTYPE html>
	<html>
	<head>
		 <meta charset="utf-8" />
		 <title>Hello static world!</title>
	</head>
	<body>
		 <h1>Hello from ASP.NET Core!</h1>
	</body>
	</html>
	````

1. Run the application and navigate to the root. It should show the hello world middleware.

	![Hello World](https://github.com/keacore/intro/blob/master/Images/Helloworld_Browser_example.png)

	_Hello World_

1. Navigate to **index.html** and it should show the static page in **wwwroot**.

	![Hello World static](/Images/HelloWorld_Browser_HTML_Example.png)

	_Hello World static_

<a name="Ex1Task2" ></a>
#### Task 2 - Adding default document support ####

In order for your Web app to serve a default page without the user having to fully qualify the URI there is a **UseDefaultFiles** extension method that can be used. This method is a _URL re-writer_ that doesn’t actually serve the file.

In addition to the **UseStaticFiles** and **UseDefaultFiles** extensions methods, there is also a single method - **UseFileServer** - that combines the functionality of these two methods as well as the **UseDirectoryBrowser** extensions methods.

In this task, you'll use the **UseFileServer** to enable serving both, static and default files.

1. Open the **Startup.cs** file and change the static files middleware in the **Configure** method from `app.UseStaticFiles()` to `app.UseFileServer()`.

	<!-- mark:5 -->
	````C#
    public void Configure(IApplicationBuilder app)
    {

        app.UseFileServer();

        app.Run(async (context) =>
        {
            await context.Response.WriteAsync("Hello World!");
        });
    }
	````

1. Run the application again. The default page **index.html** should be shown when navigating to the root of the site.






<div style="text-align: right">

&copy; <small><i>https://github.com/Microsoft-Build-2016/CodeLabs-WebDev/blob/master/Module2-AspNetCore/README.md#exercise-1-working-with-static-files</i></small>
</div>