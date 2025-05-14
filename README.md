# 🌱 Agri-Energy Connect 🔋

<div align="center">
  
  ![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-9.0-blue?style=for-the-badge&logo=dotnet)
  ![C#](https://img.shields.io/badge/C%23-13.0-purple?style=for-the-badge&logo=csharp)
  ![SQL Server](https://img.shields.io/badge/SQL%20Server-2019-red?style=for-the-badge&logo=microsoftsqlserver)
  ![Bootstrap](https://img.shields.io/badge/Bootstrap-5.0-blueviolet?style=for-the-badge&logo=bootstrap)
  

</div> <h3 align="center">Sustainable Agriculture Meets Green Energy</h3> <p align="center">A modern platform connecting farmers with renewable energy solutions and peer-to-peer product purchasing.</p>
🧾 Project Overview
AgriEnergyConnect is a web application designed to empower farmers by enabling them to manage agricultural products, connect with others, and purchase sustainable goods via a secure and intuitive interface.

👨‍🌾 Farmer Capabilities:
Register and manage profiles

Add/edit/delete products

Browse and purchase from others

Approve incoming purchase requests

👩‍💼 Employee Capabilities:
Manage farmer accounts and product listings

View analytics and system-wide data

Built with ASP.NET Core MVC, Entity Framework Core, and SQL Server, this platform ensures scalability and robust backend operations.

🚀 Key Features
✅ Farmer Registration & Profile Management

✅ Product Listing & CRUD Operations

✅ Purchase Request Flow (Send & Approve)

✅ Role-Based Authentication with ASP.NET Identity

✅ Responsive UI with Bootstrap 5

✅ Educational Resources on Green Energy

✅ Interactive Forum / Chat System

✅ Custom Styling (Font Awesome + Google Fonts)

✅ Fully Integrated SQL Server DB

👥 User Roles
🧑‍🌾 Farmer
Create/update profile

Add/edit/delete products

Browse other products

Request to purchase

View/approve incoming purchase requests

🔑 Example Farmer Login:

graphql
Copy
Edit
Email: Kate@gmail.com  
Password: Kate@123
👩‍💼 Employee (Administrator)
Manage farmers and products

Access system-wide analytics

🔑 Example Employee Login:

graphql
Copy
Edit
Email: Jones@gmail.com  
Password: Jones@123
💻 Technology Stack
Layer	Technologies Used
Frontend	HTML5, CSS3, JavaScript, Bootstrap 5
Backend	ASP.NET Core MVC, C#, Entity Framework Core
Database	Microsoft SQL Server (Agriculture Energy)
Authentication	ASP.NET Identity UI
Icons & Fonts	Font Awesome, Google Fonts (Segoe UI, Poppins)

📁 Folder Structure
markdown
Copy
Edit
/Controllers
  - FarmersController.cs
  - ProductsController.cs
  - PurchaseController.cs
  - HomeController.cs
  - EmployeesController.cs
  - ResourcesController.cs
  - PostController.cs
  - AccountController.cs

/Models
  - Farmer.cs
  - Product.cs
  - PurchaseRequest.cs
  - Post.cs
  - Employee.cs
  - ApplicationUser.cs
  - ProductFilterView.cs

/Views
  (Razor Pages Organized by Controller)

/Data
  - ApplicationDbContext.cs

/wwwroot
  (Static assets: CSS, JS, images)
📦 Database Usage
Database Name: Agriculture Energy

Preloaded Sample Data:

Farmers: Kate@gmail.com, Dev@gmail.com

Products: Organic Tomatoes, Free-Range Eggs

Purchase Requests: Auto-generated

Sample data is loaded automatically via CRUD logic (no seeding script required).

🎮 Feature Demonstration
Feature	Description
✅ Registration/Login	Uses ASP.NET Identity
✅ Product Browsing	Filter by name/email/category
✅ Purchase Requests	Requests logged and approved via UI
✅ Chat Forum	Store messages in ChatMessages table
✅ Educational Resources	Online courses, webinars, guides
✅ Profile Management	Access via dropdown in navbar

🎨 UI Design Highlights
Responsive card-based layout with hover effects

Mobile-first design using col-md-*, d-flex, and flex-wrap

Consistent green theme for success actions

Clear form validation

Easy-to-read fonts (Segoe UI, Poppins)

Icon CDN fix: Removed trailing space in Font Awesome URL

html
Copy
Edit
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
⚠️ Challenges and Changes
🛠️ Technical Issues
Issue	Solution
Identity Dependency	Used User.Identity.Name instead
Redirection Errors	Fixed with RedirectToAction()
UI Broken on Small Screens	Resolved using Bootstrap grid & flex classes

🔄 Design Changes
Switched from table layouts to responsive card grids

Integrated request approval directly into UI

Fully functional icon-enhanced navigation bar

🛠️ Setup Instructions
✅ Prerequisites
.NET SDK 9.0+

Visual Studio 2022 or VS Code

SQL Server Express

SQL Server Management Studio

📥 1. Clone the Repository
bash
Copy
Edit
git clone https://github.com/ST10378552/AgriConnect.git
cd AgriConnect
🛠️ 2. Configure the Database
Open SQL Server Management Studio

Create a new database: Agriculture Energy

Update the connection string in appsettings.json:

json
Copy
Edit
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=Agriculture Energy;Trusted_Connection=True;MultipleActiveResultSets=true"
}
📦 3. Apply Migrations
Using Package Manager Console:

powershell
Copy
Edit
Add-Migration InitialCreate
Update-Database
Or via .NET CLI:

bash
Copy
Edit
dotnet ef migrations add InitialCreate
dotnet ef database update
▶️ 4. Run the App
In Visual Studio:

Open the .sln file

Press F5 to run

Via Command Line:

bash
Copy
Edit
dotnet build
dotnet run
App URL: https://localhost:7029/

🧪 Test the App
👩‍🌾 Farmer:
Login: Kate@gmail.com / Kate@123

Browse products: /Purchase/Browse

👨‍💼 Employee:
Login: Jones@gmail.com / Jones@123

Manage: /Farmers/Index, /Products/Index

🧱 Development Workflow
Controllers: Handle logic and routing

Models: Entity and business logic

Views: Razor views per controller

Data: DB context and migrations

wwwroot: All static assets

➕ Add New Features:
bash
Copy
Edit
dotnet ef migrations add NewFeatureMigration
dotnet ef database update
📄 License
MIT License – See LICENSE for details.

📞 Contact
📧 Email: naidoodevesh32@gmail.com
🐱 GitHub: ST10378552/AgriConnect

🙌 Thank You!
Thanks for exploring Agri-Energy Connect – empowering sustainable agriculture through technology, clean energy, and community.

