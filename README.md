# CroweHelloWorld
This project is for a coding challenge given by Crowe LLP.
## Coding Exercise Instructions:

##### Write a Hello World program 
1. The program has 1 current business requirement a write Hello World to the console/screen. 
2. The program should have an API that is separated from the program logic to eventually support mobile applications, web applications, console applications or windows services. 
3. The program should support future enhancements for writing to a database, console application, etc. 
            - Use common design patterns (inheritance, e.g.) to account for these future concerns. 
            - Use configuration files or another industry standard mechanism for determining where to write the information to. 
4. Write unit tests to support the API.
5. Feel free to use a github program to store the coding exercise as I know that’s typically easier to use.

## Decisions
##### I will explain some of the decisions I made to support the requirements below:

1. Straight forward
2. I took this to mean we would want to be able to reuse this _HelloWorld_ API in the future, so the logic is separated into its own folder called _App_ and is implementing an interface for easy resuse later.
3. I implemented this using the built in project settings in Visual Studio and dependency injection using Unity. By changing the *ShouldWriteToConsole* setting we can use either the console writer or the database writer. (The database writer is not really implemented, it's just an example to show that the inheritance and dependency injection is working).
4. Unit tests are present in the test project and use NUnit. 
5. Here we are!
