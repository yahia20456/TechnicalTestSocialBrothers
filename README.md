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
1/ Create data Model (In our Example the AddressInformation is our Model ) where you can specify the properties
2/Also the entity framework core needs a context object to allows quering and saving data , So in the Models folder we add a class called AddressContext inherits from DbContext, The constructor takes a dbcontext option object as a parameter , This object is a configuration of the context and it will be injected trough dependancy injection
3/Now we have to update the configure services method in the program.cs
4/Now it' to time to add a repository which is a layer sits between our application and the data access layer which is in our the addresscontext , So as you see in my code i've created an interface that describes operations that can be performed against the database, Then we create a class to implement the methods
# Part 2
The Second Part was challenging due to the limits mentionned (Not using if statement /Switch case) , After many optimization of the code , I found that using a foreach within foreach loop can be a solution to dynamically search field from the model , The first loop is used to search on objects ,and the second loop is used to search on properties.
# Part 3
Honnestly The last part was difficult for me , due to the shortage of time and the lack of experience with this kind of Apis ,and Unfortunately i didn't complete it , But after a long search i think that the difficulty is accumulated on the configuration of the Api and the geocoding of the addresses then we can use a lot of methods to calculate distance.
Generally, I'm Not satisified with my work beacause i know that i have the skills to do better and i hope that i get a second chance to prove that .
# Swagger Documentation
This repository contains a controller which is dealing with AdressInformation. You can GET/POST/PUT and DELETE them.

Hope this helps.

See the examples here :
https://localhost:7248/swagger/index.html
![image](https://user-images.githubusercontent.com/73944085/208802378-8ebea29a-c167-485e-a873-9fecf807d5f2.png)

1- Add an Address
{
  "id": 6,
  "street": "Messadi Tazarka",
  "houseNumber": 8027,
  "zipCode": 8046,
  "city": "Nabeul",
  "country": "Tunisia"
}
![image](https://user-images.githubusercontent.com/73944085/208802758-ba382c45-6a4e-4f68-a6ce-de135c64c455.png)
2- Update an Address
![image](https://user-images.githubusercontent.com/73944085/208802967-5639ef1a-5292-48b7-a4ee-332fa93b3fc9.png)
3- Retrieve Address with Id
![image](https://user-images.githubusercontent.com/73944085/208803056-12fc5430-8812-4e98-803d-4b996fd9d624.png)
4- Get Addresses with filter
