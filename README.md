# Introduction to ASP.NET Core 1.0
### _KEA CS 4th Semester 24-11-2016_

## Agenda today
The porpouse of today is to introduce you to ASP.NET Core 1.0. 

We will start out by doing a low level introduction to how .NET Core, and ASP.NET Core works. 
This will include installing .NET Core on Windows, Mac or Linux, creating a first hello world console application, and 
creating a basic asp.net web application. We will also install and start using the VS Code editor.


In connection with deployment we will shortly touch the use of a Docker Image as the platform for our deployed ASP.NET Core Application.

## Installation of .net core
Go to [dot.net](http://dot.net) and click on [download](https://www.microsoft.com/net/download), and on 
[.NET Core](https://www.microsoft.com/net/download/core). Choose you OS, and follow the instructions.         
_(If you are on Windows choose "Select your environment" -> "Command Line / Other")_.   

## Getting Started Guied
1. Install [.NET Core](https://www.microsoft.com/net/core#macos)
2. Create a new .NET Core project:

````
mkdir aspnetcoreapp
cd aspnetcoreapp
dotnet new
````
3. Restore the packages:
````
dotnet restore
````
4. Run the app (the dotnet run command will build the app when it's out of date):
````
dotnet run
````
5. Browse to ```` http://localhost:5000 ````




## Resources
* [dot.net] (http://dot.net)
* [Install .NET Core](https://www.microsoft.com/net/download/core)
* [VS Code](https://code.visualstudio.com/)
* [Getting Started with C#](https://www.microsoft.com/net/tutorials/csharp/getting-started)
* [Visual Studio Download](https://www.visualstudio.com/downloads/)
* [Visual Studio for MAC Download](https://www.visualstudio.com/vs/visual-studio-mac/)
* [Migrating From ASP.NET MVC to ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/migration/mvc)

