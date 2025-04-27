🚗 Car Management Application


📋 Overview
This project is a simple client-server car management system built in C#.
It allows you to add, view, update, and delete cars stored in a local database.

The solution consists of:

A Windows Forms client application

An ASP.NET Web Service (SOAP) server

A local SQL Server database (CarDatabase.mdf)

✨ Features
View all cars from the database in a list

Add new cars with full details (model, brand, year, mileage, price, photo)

Update existing car information

Delete cars from the database

Display full car details (including an image)

🛠 Technologies Used
C# (.NET Framework)

Windows Forms (GUI)

ASP.NET Web Services (SOAP protocol)

SQL Server LocalDB (local database storage)

📂 Database
The project uses a local SQL Server database (CarDatabase.mdf).

The database is connected via a connection string with LocalDB and stored locally.

No external server or cloud database is required.

🚀 How to Run
Open the solution (.sln) in Visual Studio.

Build both the Web Service and the Client application.

Start the Web Service first.

Run the Client (WinForms) application.

You can now add, edit, delete, and view cars!

⚡ Notes
The Web Service must be running before starting the Client.

Make sure the path to the local database in the connection string is correct on your machine.

If the database does not exist, you need to create the Cars table manually.
