# U-Haul Equipment Management System

## Overview

This application is designed to manage different types of U-Haul equipment, 
including Moving Trucks, Trailers, Tow Dollies, and Electric Carts. 
It provides functionalities to check the tow rating, identify heavy-duty equipment,
and calculate toll fees based on the number of axles.

## Prerequisites

Before you set up the project, ensure you have the following installed:
- [.NET SDK](https://dotnet.microsoft.com/download) (version 8.0 )
- An IDE or code editor such as [Visual Studio](https://visualstudio.microsoft.com/downloads/), [VSCode](https://code.visualstudio.com/download) (with C# extension), or another preferred IDE that supports C#.

## Setup

1. **Clone the repository:**
   ```bash
   git clone [URL to repository]
   cd [repository name]
2. Open the project:
If using Visual Studio, open the .sln file.
If using VSCode, open the project folder.

Restore dependencies:
This project uses .NET's built-in dependency management. Restore any NuGet packages if necessary:
dotnet restore
3. Build the project:

dotnet build
4. Running the Application
To run the application, use the following command in the root directory of the project:
dotnet run
This command will compile and execute the application. Follow any on-screen prompts to interact with the application.

5. Testing
This section explains how to manually test the functionalities of the U-Haul equipment management system. Automated testing setup instructions can be added as needed based on the test framework used (e.g., NUnit, xUnit).

-- Manual Testing
Open your terminal or command prompt.
Navigate to the project directory.
Run the application:
bash

dotnet run
Observe the output and interactions:
The application will display outputs for each equipment type's capabilities.
Test the application by following the interactive prompts (if applicable).
