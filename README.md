# TechnicalTestSocialBrothers
This template is a simple startup project using ASP.NET Web and EntityFrameworkCore.Sqlite 
# Prerequirements
- Visual Studio 2022
- .NET Core SDK
# How To Run
- Open solution in Visual Studio 2022
- Set .Web project as Startup Project and build the project.
- Run the application.
# Part 1 
In my Opinion and as a student , the first part was affordable , you just need some basic knoweldge about CRUD operations and how the entity framework (ORM) can interact with sqlite database 
1/Create data Model (In our Example the AddressInformation is our Model ) where you can specify the properties
2/Also the entity framework core needs a context object to allows quering and saving data , So in the Models folder we add a class called AddressContext inherits from DbContext, The constructor takes a dbcontext option object as a parameter , This object is a configuration of the context and it will be injected trough dependancy injection
3/Now we have to update the configure services method in the program.cs
4/Now it' to time to add a repository which is a layer sits between our application and the data access layer which is in our the addresscontext , So as you see in my code i've created an interface that describes operations that can be performed against the database, Then we create a class to implement the methods
# Part 2
