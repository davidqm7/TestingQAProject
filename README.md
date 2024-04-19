# KSU SWE 3643 Software Testing and Quality Assurance Semester Project: Web-Based Calculator
This repository contains a web-based calculator server built using ASP.NET Blazor Server on JetBrains Rider. The calculator provides basic arithmetic operations accessible through a user-friendly web interface. The server-side logic is implemented using Blazor components, ensuring seamless interaction between the client and the server.


#### Table of Contents

-  [Introduction](#ksu-swe-3643-software-testing-and-quality-assurance-semester-project-web-based-calulator)
-  [Table of Contents](#table-of-contents)
-  [Team Members](#team-members)
-  [Architecure](#architecture)
-  [Environment](#environment)
-  [Executing the Web Application](#Executing-the-web-application)
-  [Executing Unit Tests](#executing-unit-tests)
-  [Reviewing Unit Test Coverage](#reviewing-unit-test-coverage)
-  [Executing End-To-End Tests](#executing-end-to-end-tests)
-  [Final Video Presentation](#final-video-presentation)
  
## Team Members
David Quintanilla - Completed everything. 

## Architecture
The brower side comes from HTML, CSS, and Blazor components. The server side uses Blazor components, written in C#, handle how the calculator works and updates. For testing the web application uses NUnit. Uses Nunit for testing the methods and Playwright to test the UI behaves correctly. 

![image](https://github.com/davidqm7/TestingQAProject/assets/128763329/126ea783-ec29-454c-9b57-089caf03c65d)


## Environment 

This is a cross-platform application and should work in Windows 10+, Mac OSx Ventura+, and Linux environments. Note that the application has only been carefully tested in Windows 11.
Before you begin, ensure you have the following dependencies installed:

    .NET SDK - Ensure you have .NET SDK installed on your machine. You can download and install it from the official .NET website.

    .JetBrains Rider- Can be installed from their website. Free for anyone who is a student. 

    .Playwright- Install playwright

1. Clone the repository:
```bash
git clone <repository-url>
```
2.Install dependencies 
```bash
cd <project-directory>
dotnet restore
```

## Executing the Web Application
To build and execture the web application from the command line: 

1.Build the application -
```bash
dotnet build
```
2.Run the application-
```bash
dotnet run
```
3.Acces the application -

Open a web browser and navigate to http://localhost:5024

## Executing Unit Tests
To build and execute all unit tests from the command line

1. Go to the project directory
```bash
cd project directory 
```
2. Run the unit tests
```bash
dotnet test --filter CalculatorEngineUnitTests.cs
```

## Reviewing Unit Test Coverage
![image](https://github.com/davidqm7/TestingQAProject/assets/128763329/8b7f4a86-1b9d-420a-9cf0-dfedad4a4527)

## Executing End-To-End Tests
To build and execute all end-to-end tests from the command line

1. Install playwright
```bash
npm install -g playwright
```
2. Go to the project directory
```bash
cd project directory 
```
3. Run the end-to-end tests
```bash
dotnet test --filter CalculatorEndToEndTest.cs
```

## Final Video Presentation

