# 🌱 Agri-Energy Connect 🔋

<div align="center">
  
  ![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-9.0-blue?style=for-the-badge&logo=dotnet)
  ![C#](https://img.shields.io/badge/C%23-13.0-purple?style=for-the-badge&logo=csharp)
  ![SQL Server](https://img.shields.io/badge/SQL%20Server-2019-red?style=for-the-badge&logo=microsoftsqlserver)
  ![Bootstrap](https://img.shields.io/badge/Bootstrap-5.0-blueviolet?style=for-the-badge&logo=bootstrap)

<div align="center">

Sustainable Agriculture Meets Green Energy
A modern ASP.NET Core MVC platform connecting farmers with renewable energy solutions and peer-to-peer product purchasing

</div>
📋 Project Overview
Agri-Energy Connect is a comprehensive full-stack web application designed to empower the agricultural community through sustainable practices and renewable energy adoption. Our platform serves as a bridge between traditional farming and modern green energy solutions.

🌱 Core Features

Eco-Friendly Marketplace - Direct farmer-to-consumer sales platform reducing carbon footprint
Renewable Energy Integration - Connection to green energy providers and solutions
Knowledge Hub - Educational resources on sustainable farming practices
Community Collaboration - Forums for sharing experiences and best practices
Role-Based Access - Customized experiences for farmers, consumers, and energy providers

🛠️ Technologies Used
ASP.NET Core MVC — Modern backend web framework

Entity Framework Core — ORM for interacting with SQL Server

SQL Server 2019 — Reliable, scalable relational database

Bootstrap 5 — Responsive and mobile-friendly front-end framework

👥 User Roles & Capabilities
#### 🧑‍🌾 **Farmer**
- 📝 **Register and manage personal profile**
- 📦 **Add/edit/delete agricultural products**
- 🛒 **Browse other listings and send purchase requests**
- ✅ **View and approve incoming purchase requests**
- 💬 **Participate in discussion forums**
- 📚 **Access educational green energy content**

#### 👩‍💼 **Employee (Administrator)**
- 👤 **Manage farmer accounts and product listings**
- 📊 **View system-wide data and analytics**
- 📂 **Moderate educational content and posts**



🔐 Login Credentials (For Testing)

| **Role**     | **Email**         | **Password**|
|--------------|-------------------|-------------|
| **Farmer**   | Kate@gmail.com    | Kate@123    |
| **Employee** | Jones@gmail.com   | Jones@123    


🚀 Key Features

Feature	Description

  ✅ Registration & Login	Secure role-based authentication using ASP.NET Identity

  ✅ Product CRUD	Farmers can manage their own listings

  ✅ Purchase Request System	Send, receive, and approve product purchase requests

  ✅ Chat Forum	Community-style discussion board for farmers

  ✅ Green Energy Learning Hub	Access to curated educational resources (courses, webinars, guides)

  ✅ Responsive UI Design	Built with Bootstrap 5 and mobile-friendly grid layout

  ✅ Profile Management	Users can update their own information with validation

  ✅ Integrated SQL Server DB	Automatic CRUD-based sample data generation without manual seeding

🎨 UI Design Highlights

  💎 Card-Based Layout with d-flex and flex-wrap for responsiveness

  💎 Hover Effects to improve user interaction feedback

  💎 Green Theme to reflect eco/sustainability branding

  💎 Clear Form Validations using Bootstrap and Razor Tag Helpers

  💎 Modern Typography: Segoe UI + Poppins

  💎 Icon Fixes: Resolved with updated Font Awesome CDN

html

<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />

## 📁 Folder Structure

```text
📁 AgriConnect/
├── 📂 Controllers/               # 🎯 Route and action logic
│   ├── 🧑‍🌾 FarmersController.cs
│   ├── 🍅 ProductsController.cs
│   ├── 🛒 PurchaseController.cs
│   ├── 👨‍💼 EmployeesController.cs
│   ├── 📝 PostController.cs
│   └── 🔐 AccountController.cs
│
├── 📂 Models/                    # 🧩 Domain entities
│   ├── 🧑‍🌾 Farmer.cs
│   ├── 🍅 Product.cs
│   ├── 📥 PurchaseRequest.cs
│   ├── 📝 Post.cs
│   └── 👤 ApplicationUser.cs
│
├── 📂 Views/                     # 🔍 Razor pages per controller
│
├── 📂 Data/
│   └── 🗄️ ApplicationDbContext.cs
│
├── 📂 wwwroot/                   # 🌐 Static assets (CSS, JS, images)
│
└── ⚙️ appsettings.json           # 🔗 DB connection string
```


🧪 Sample Data
Loaded dynamically via standard CRUD operations – no seeding script needed.

👩‍🌾 Farmers: Kate@gmail.com, Dev@gmail.com

🛍️ Products: Organic Tomatoes, Free-Range Eggs

💬 Chat Posts: Stored in ChatMessages table

📄 Requests: Simulated upon product browsing/interaction

⚠️ Known Challenges & Fixes

### ⚠️ Known Challenges & Fixes

- 🔒 **Identity Injection** — Used `User.Identity.Name` instead of injecting `UserManager<IdentityUser>`
- 🔁 **Redirect Errors** — Fixed using `RedirectToAction()` to maintain routing structure
- 📱 **UI on Smaller Screens** — Resolved with Bootstrap media queries and `col-*` classes


### 🔄 UI/UX Refinements

- ✅ **Switched from table layout to card-based format**
- ✅ **Integrated request approval buttons directly into listings**
- ✅ **Added dropdown menu for authenticated user profile actions**
- ✅ **Improved layout using flexbox and Bootstrap utilities**


🛠️ Setup Instructions

✅ Prerequisites

    ➤ .NET 9.0 SDK

    ➤ Visual Studio 2022

    ➤ SQL Server Express

    ➤ SQL Server Management Studio

1. 📥 Clone the Repository

Open your terminal and run the following commands:

  ➤ git clone https://github.com/ST10378552/AgriConnect.git

  ➤ cd AgriConnect

🛠️ 2. Configure the Database

1. Open SQL Server Management Studio

2. Create a new database:

➤ Name: Agriculture Energy

3. Update your appsettings.json:

➤ json
"ConnectionStrings": {
  "DefaultConnection": "Server=DEVESH\\SQLEXPRESS;Database=Agriculture Energy;Trusted_Connection=True;MultipleActiveResultSets=true"
}

📦 3. Apply Migrations

Via Visual Studio (Package Manager Console):

➤ powershell

    Add-Migration InitialCreate
    
    Update-Database


▶️ 4. Run the App in Visual Studio
Open the AgriConnect.sln solution file in Visual Studio.

Press F5 or click Start Debugging to build and launch the app.

The application will run at:
🔗 https://localhost:7029/

🔍 Test the Application
👩‍🌾 Farmer Account
📧 Email: Kate@gmail.com

🔐 Password: Kate@123

🛒 Browse Products: https://localhost:7029/Purchase/Browse

👨‍💼 Employee Account
📧 Email: Jones@gmail.com

🔐 Password: Jones@123

👥 Manage Farmers: https://localhost:7029/Farmers/Index

📦 Manage Products: https://localhost:7029/Products/Index



🧱 Development Workflow

    ➤ Controllers/: Handle routing and logic

    ➤ Models/: Define database schema and relationships

    ➤ Views/: Razor Pages (organized per controller)

    ➤ Data/: EF Core context and migrations

wwwroot/: Static assets (Bootstrap, JS, CSS, Icons)

➕ Add New Features

bash

    ➤ Add-Migration Best (This is the Migration Name) 

    ➤ Update-Database

📄 License

This project is licensed under the MIT License.
See the LICENSE file for more details.

📞 Contact

📧 Email: naidoodevesh32@gmail.com

🐙 GitHub: ST10378552/AgriConnect

🙌 Thank You!

Thanks for exploring Agri-Energy Connect — a mission-driven platform uniting agriculture and clean energy for a better future. 🌿🔋
