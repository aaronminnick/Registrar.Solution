# University Registrar Web Application

#### By Aaron Minnick, Katie Pundt, & Liz Thomas

#### _A registrar for a fake university called Strudel University_

## Technologies Used

* _HTML_
* _CSS_
* _C#_
* _.NET_
* _ASP.NET_
* _Entity_
* _Razor_
* _Node_
* _SQL_
* _MySQL Workbench_

## Description

_This web application was created for Strudel University to track the students, courses, and departments within the school. It allows the admin to add a student's courses and majors, as well as add available courses to departments, and add departments within the school._

## Setup/Installation Instructions
* Download, install, and configure MySQL
* Open the terminal on your desktop
* Once in the terminal, use it to navigate to your desktop folder
* Once inside your desktop folder, use the command `git clone https://github.com/kpundt93/Registrar.Solution.git`
* After cloning the project, navigate into it using the command `cd Registrar.Solution/Registrar`
* Create a file named "appsettings.json" in the `Registrar` directory
* Add the following code to appsettings.json and add your MySQL user ID and password:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=registrar;uid=[YOUR MYSQL USER ID];pwd=[YOUR MYSQL PASSWORD];"
  }
}
```
* Then run the command `dotnet ef database update`
* Then run the command `dotnet restore` to install project dependencies
* Then run the command `dotnet run` to run the project in the browser

## Known Bugs

* _No known issues_

## License
_MIT License: https://opensource.org/licenses/MIT_

Copyright (c) _2021_ _Aaron Minnick, Katie Pundt, & Liz Thomas_