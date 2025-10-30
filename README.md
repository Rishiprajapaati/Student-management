# 🎓 Student Management System

A simple and modern **CRUD web application** built with **ASP.NET Core 9.0 MVC**, featuring a clean and responsive UI for managing student records efficiently.

---

## 🚀 Features

- **Student Management:** Add, view, edit, and delete student records  
- **Entity Framework Core:** Seamless integration with SQLite database  
- **Modern UI/UX:** Clean layout using Bootstrap 5  
- **Responsive Design:** Works on desktop, tablet, and mobile  
- **Real-time Updates:** Instantly reflects all CRUD operations  
- **Lightweight Project:** Simple structure, perfect for beginners  

---

## 🧱 Technology Stack

**Backend:** ASP.NET Core 9.0 MVC  
**Database:** SQLite (via Entity Framework Core)  
**Frontend:** HTML5, CSS3, Bootstrap 5, Razor Views  
**Language:** C#  
**ORM:** Entity Framework Core 9  
**IDE:** Visual Studio 2022 / VS Code  

---

## ⚙️ Prerequisites

Before running this project, make sure you have the following installed:

- [.NET 9.0 SDK](https://dotnet.microsoft.com/)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or VS Code
- SQLite (no separate installation required)
- Git

---

## 💻 Installation & Setup

### 1️⃣ Clone the Repository
```bash
git clone <repository-url>
cd StudentCRUD
2️⃣ Restore Dependencies
bash
Copy code
dotnet restore
3️⃣ Create and Configure the Database
SQLite is pre-configured in this project.

If you’re using a custom path, update the connection string in appsettings.json:

json
Copy code
"ConnectionStrings": {
  "DefaultConnection": "Data Source=students.db"
}
Then run:

bash
Copy code
dotnet ef migrations add InitialCreate
dotnet ef database update
This will create a local students.db SQLite database file.

4️⃣ Run the Application
bash
Copy code
dotnet run
Now open your browser and go to:
👉 http://localhost:5000/Students

🧑‍🏫 Application Overview
This application manages student information through a simple and intuitive interface.

Core CRUD Operations:
Operation	Description	Route
➕ Create	Add a new student record	/Students/Create
📋 Read	View all students	/Students/Index
✏️ Update	Edit existing student details	/Students/Edit/{id}
❌ Delete	Delete a student	/Students/Delete/{id}

🗄️ Database Schema
Students Table
Column	Type	Description
Id	int	Primary key
Name	string	Student’s name
Age	int	Student’s age
Course	string	Course enrolled
Email	string	Student’s email address

🎨 Color Scheme (UI Theme)
Element	Color	Hex Code
Primary	Blue	#007bff
Secondary	Gray	#6c757d
Accent	Light Green	#28a745
Background	White	#ffffff
Text	Dark Gray	#212529

📂 Project Structure
pgsql
Copy code
StudentCRUD/
├── Controllers/
│   └── StudentsController.cs
├── Models/
│   └── Student.cs
├── Data/
│   └── ApplicationDbContext.cs
├── Views/
│   ├── Students/
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   └── Delete.cshtml
│   └── Shared/
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── lib/
├── appsettings.json
├── Program.cs
└── StudentCRUD.csproj
📈 Key Features Implemented
User Experience
Minimal and intuitive interface

Fully responsive layout

Bootstrap-based modern design

Fast CRUD operations with instant feedback

Database Integration
SQLite database using Entity Framework Core

Migrations for database creation and updates

Automatic data tracking

MVC Architecture
Organized Controllers, Models, and Views

Easy to extend or integrate with larger systems

🧠 Learning Outcomes
Through this project, you’ll understand:

ASP.NET MVC structure

Entity Framework Core CRUD operations

Razor view templating

Model validation

SQLite configuration

Database migrations

⚡ Deployment
Local Development
bash
Copy code
dotnet run --environment Development
Production Build
bash
Copy code
dotnet publish -c Release -o ./publish
You can then deploy the published output to IIS, Azure, or any compatible web host.

📜 License
This project is licensed under the MIT License — see the LICENSE file for details.

👨‍💻 Developer
Jone — Full Stack Developer
📧 Email: your.email@example.com
🌐 GitHub: https://github.com/yourusername

💬 Support
For any queries or support:

📧 Email: support@studentcrud.com
📞 Phone: +91 8849811782

🎓 Student Management System – A simple CRUD app to manage student data efficiently and learn ASP.NET Core MVC basics.

📸 Output Screenshots
(Add your project screenshots here) :
Example:
![Image Alt](https://github.com/Rishiprajapaati/Student-management/blob/main/Screenshot%202025-10-30%20200310.png?raw=true)
![Image Alt](https://github.com/Rishiprajapaati/Student-management/blob/main/Screenshot%202025-10-30%20200337.png?raw=true)
![Image Alt](https://github.com/Rishiprajapaati/Student-management/blob/main/Screenshot%202025-10-30%20221633.png?raw=true)
![Image Alt](https://github.com/Rishiprajapaati/Student-management/blob/main/Screenshot%202025-10-30%20221701.png?raw=true)





