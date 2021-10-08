# MAZE (book authored by Christopher Manson) 
#### A web application of the choose-your-own-adventure-type book MAZE by Christopher Manson.A user will be able to navigate the maze by clicking the door number sign. Will you survive the maze? Can you solve the riddle?"

#### Code authored by Erika Debelis
#### about the tech:
 A full-stack site; built with a C# ASP .Net Core API back-end and a Javascript/React.js front-end. The hard-coded database holds the maze book pages as objects and their corresponding data as properties. The React.js front-end will call to the database and render the next page according to the door clicked in this single page web application.

#### Important code decisions made:
###### To prevent cheating
1. This was built as a single page web application, so the Url does not change with the changing pages.
2. Each page has unique hidden clickable areas rather than obvious buttons (as some doors are hidden). these clickable areas will change the page the number of the door as stated above.


## Technologies Used

* _C#_
* _Entity Framework Core_
* _ASP .NET Core MVC_
* _SPA Services_
* _LINQ_
* _Postman_
* _React.js_
* _JavaScript_
* _JSX_
* _HTML Image Maps_
* _NPM_
* _Babel_
* _ES6_
* _Git BASH_

![maze-gif](https://raw.githubusercontent.com/ErikaDebelis/MAZE/main/server/wwwroot/images/maze-gif.gif)
_(a gif for a visual preview of the site)_
## Setup/Installation Requirements

1. Download or clone https://github.com/ErikaDebelis/MAZE to your local machine
2. Navigate to the client directory and run "npm install" in the git BASH terminal to install dependencies
    ``$ npm install``
3. Navigate back out of the client directory and the into the server directory. From that folder you'll want to create appsettings.json file and add the following code to the file: touch appsettings.json

```
{
  "Logging": 
  {
    "LogLevel": 
    {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": 
  {
    "DefaultConnection": "Server=localhost;Port=3306;database=mazer;uid={YOUR_USERNAME_NAME};pwd={YOUR_PASSWORD};"
  }
}
```
Be sure to remove the ``{YOUR_USERNAME_NAME}`` and ``{YOUR_PASSWORD}`` and fill in the the code snippet with your username for MySQL, and MySQL password _Do not include the curly brackets in your code snippet of appsettings.json_

4. Make sure EF Core is installed to create and utilize migrations. Run the following code in the git BASH terminal to install.
    ``$ dotnet tool install --global dotnet-ef --version 3.0.0``

5. Run "dotnet restore" in the git BASH terminal to install needed dependencies.
    ``$ dotnet restore``

6. Run "dotnet build" in the git BASH terminal to minify the code.
    ``$ dotnet build``

7. Run "dotnet ef database update" in the git BASH terminal create the database outlined from the Model within the project.
    ``$ dotnet ef database update``

8. Run "dotnet run" in the git BASH terminal to  minify the code, and run the project in the terminal.
    ``$ dotnet watch run``

9. View the API by database alone by downloading Postman and entering http://localhost:5000/api/pages 

10. View the entire site built together by visiting http://localhost:5000/ in a new web browser( such as google chrome) tab!
## Bugs

_no known bugs at this time_

## License

_MIT_

Fair Use Act Disclaimer
Last updated October 07, 2021


## Website Disclaimer
The information used by Erika Debelis on https://github.com/ErikaDebelis/MAZE (the "Site") is for educational purposes only. All information on the Site is used for demonstration purposes only and I (Erika Debelis) claim no rights to the contents of the book MAZE by Christopher Manson. I only claim the rights and ownership of the code written to make the dynamic web application. If anyone enjoys this web application of MAZE please find and purchase MAZE, this a lovely book.

#### Fair Use
Copyright Disclaimer under section 107 of the Copyright Act of 1976, allowance is made for "fair use" for purposes such as criticism, comment, news reporting, teaching, scholarship, education and research.

Fair use is a use permitted by copyright statute that might otherwise be infringing.

#### Fair Use Definition

Fair use is a doctrine in United States copyright law that allows limited use of the copyrighted material without requiring permission from the rights holders, such as commentary, criticism, news reporting, research, teaching, or scholarship. It provides for the legal, non-licensed citation or incorporation of copyrighted material in another author's work under a four-factor balancing test.

## Contact Information
if any issues are discovered while navigating the site, please let me know! It will help me learn and grow!

Erika Debelis _erika.debelis@gmail.com_