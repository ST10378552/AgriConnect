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

1. Create/update profile

2. Add/edit/delete products

3. Browse other products

4. Request to purchase

5. View/approve incoming purchase requests

🔑 Example Farmer Login:

Email: Kate@gmail.com  

Password: Kate@123

👩‍💼 Employee (Administrator)

1. Manage farmers and products

2. Access system-wide analytics

🔑 Example Employee Login:

Email: Jones@gmail.com  

Password: Jones@123

💻 Technology Stack

Layer	Technologies Used

- Frontend	HTML5, CSS3, JavaScript, Bootstrap 5
- Backend	ASP.NET Core MVC, C#, Entity Framework Core
- Database	Microsoft SQL Server (Agriculture Energy)
- Authentication	ASP.NET Identity UI
- Authentication	ASP.NET Identity UI


📁 Folder Structure

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

Database Name: AgricultureEnergy

Preloaded Sample Data:

Farmers: Kate@gmail.com, Dev@gmail.com

Products: Organic Tomatoes, Free-Range Eggs

Purchase Requests: Auto-generated

Sample data is loaded automatically via CRUD logic (no seeding script required).

🎮 Feature Demonstration

Feature	Description

✅ Registration/Login	Secure user authentication using ASP.NET Identity

✅ Product Browsing	Filter products by name, email, or category

✅ Purchase Requests	Farmers can request to purchase; product owners can approve via UI

✅ Chat Forum	Interactive discussion forum; messages stored in the ChatMessages table

✅ Educational Resources	Access online courses, webinars, guides, and video tutorials

✅ Profile Management	Farmers can update their profile via a top-right dropdown menu


🎨 UI Design Highlights

- Consistent card-based layout with responsive Bootstrap grid (col-md-*, d-flex, flex-wrap)

- Hover animations for interactivity

- Green-themed UI for eco/success actions

- Clear validation feedback on forms

- Typography using Segoe UI and Poppins

- Fixed broken icons by correcting Font Awesome CDN URL:

- <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />

⚠️ Challenges and Changes

🛠️ Technical Issues

Issue	Solution

- Identity injection issue	Used User.Identity.Name instead of injecting UserManager<IdentityUser>
- Redirection errors	Solved using RedirectToAction() to ensure proper routing
- UI issues on smaller screens	Fixed with responsive Bootstrap classes and layouts

🔄 Design Improvements

- Switched from table layout to card-based UI

- Integrated purchase request approval directly in the UI

- Created a fully functional navigation bar with icons

- Improved mobile usability with responsive design

🛠️ Setup Instructions

✅ Prerequisites

1. .NET SDK 9.0+

2. Visual Studio 2022 or Visual Studio Code

3. SQL Server Express

4. SQL Server Management Studio

📥 1. Clone the Repository

bash

git clone https://github.com/ST10378552/AgriConnect.git

cd AgriConnect

🛠️ 2. Configure the Database

Open SQL Server Management Studio

Create a new database named: Agriculture Energy

Update appsettings.json with this connection string:

json

"ConnectionStrings": {
  "DefaultConnection": "Server=DEVESH\\SQLEXPRESS;Database=Agriculture Energy;Trusted_Connection=True;MultipleActiveResultSets=true"
}

📦 3. Apply Migrations

Using Package Manager Console in Visual Studio:

powershell

Add-Migration InitialCreate

Update-Database

▶️ 4. Run the Application

In Visual Studio:

Open the .sln file

Press F5 to build and run

App will be available at: https://localhost:7029/

🧪 Test the App

👩‍🌾 Farmer

Login: Kate@gmail.com

Password: Kate@123

Browse products: https://localhost:7029/Purchase/Browse

👨‍💼 Employee
Login: Jones@gmail.com

Password: Jones@123

Manage farmers: https://localhost:7029/Farmers/Index

Manage products: https://localhost:7029/Products/Index

🧱 Development Workflow
Controllers/: Handle routing and logic

Models/: Define entities and business logic

Views/: Razor pages, grouped per controller

Data/: ApplicationDbContext for EF Core and migrations

wwwroot/: Static files (CSS, JS, images)

➕ Add New Features
bash

Add-Migration Best

Update-Database

📄 License

This project is licensed under the MIT License. See the LICENSE file for more details.

📞 Contact

📧 Email: naidoodevesh32@gmail.com

🐱 GitHub: ST10378552/AgriConnect

🙌 Thank You!

Thanks for exploring Agri-Energy Connect — a platform empowering farmers through technology, clean energy, and sustainable practices. 🌿🔋

