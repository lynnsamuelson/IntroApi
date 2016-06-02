# IntroApi
## This is an Web Api Walkthrough

## To start the project from the Visual Studio follow these steps:

1. Opened VS, new project, ASP.NET Application (.NET Framework)
2. Name WebApi
3. Select Web API
	*kept MVC and API checked
	*change authentication to no authentication
4. Click OK and let VS build project
4. Add the Chinook Connedtion string to the Web.config
5. Make a Model for Artist
6. Make a ApplicationDbContext class in the Models folder
7. Make a ArtistController by right clicking on the Controllers folder and selecting Add => Web API controller class
	*Name the class ArtistController.cs
Install Entity Framework into the project
Add properties to the Artist.cs class
Set-up the ApplicationDbContext.cs class (same as MVC)
*Add: 
```config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));``` 
to the App_Start.WebApiConfig.cs file
*Run and appended /api/artist to the url to bring back a list of artists.
