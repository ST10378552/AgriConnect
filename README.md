# 🌱 Agri-Energy Connect 🔋

<div align="center">
  
  ![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-9.0-blue?style=for-the-badge&logo=dotnet)
  ![C#](https://img.shields.io/badge/C%23-13.0-purple?style=for-the-badge&logo=csharp)
  ![SQL Server](https://img.shields.io/badge/SQL%20Server-2019-red?style=for-the-badge&logo=microsoftsqlserver)
  ![Bootstrap](https://img.shields.io/badge/Bootstrap-5.0-blueviolet?style=for-the-badge&logo=bootstrap)
  

<h3>Sustainable Agriculture Meets Green Energy</h3>

<p>A modern platform connecting farmers with renewable energy solutions and peer-to-peer product purchasing.</p>

</div>

🧾 Project Overview
AgriEnergyConnect is a web application designed to help farmers manage their agricultural products, connect with other farmers, and facilitate the purchase of sustainable goods through a secure and intuitive interface.

The app allows farmers to:

Register and maintain a profile
Add and manage their own products
Browse and request to purchase products from other farmers
View received purchase requests and approve them
Employees can:

Manage farmer accounts and products
Maintain system-wide data
This project was developed using ASP.NET Core MVC , with Entity Framework Core and SQL Server for robust backend functionality.

🚀 Key Features
✅ Farmer Registration & Profile Management
✅ Product Listing & Management
✅ Purchase Requests (Farmers can request to buy products and owners can approve)
✅ Role-Based Authentication
✅ Responsive UI using Bootstrap 5
✅ Educational Resources on green energy
✅ Interactive Forum for farmers to communicate
✅ Clean navigation bar with icons
✅ Fully integrated database (Agriculture Energy)
✅ CRUD operations for all entities
✅ Custom styling using Font Awesome and Google Fonts
👥 User Roles
Farmer
Farmers can:

Create and update their profile
Add, edit, and delete their products
Browse products from other farmers and request to purchase
View and approve purchase requests
Example Credentials:
Email
Kate@gmail.com
Password
Kate@123

Employee
Employees are administrators who can:

Create , edit , and delete farmers
Manage all products in the system
View farmer statistics and product analytics
Example Credentials:
Email
Jones@gmail.com
Password
Jones@123

💻 Technology Stack
Framework
ASP.NET Core MVC
Backend Language
C#, Entity Framework Core
Database
Microsoft SQL Server (
Agriculture Energy
)
Frontend
HTML5, CSS3, Bootstrap 5, JavaScript
Authentication
ASP.NET Identity UI
Icons
Font Awesome
Hosting
Azure (or local dev)

📁 Folder Structure


1 Controllers/
2 Models/
3 Views/
4 wwwroot/
5 Data/
6 Pages/

Key controllers:

FarmersController.cs
ProductsController.cs
PurchaseController.cs
HomeController.cs
AccountController.cs (built-in Identity)
Main models:

Farmer.cs
Product.cs
PurchaseRequest.cs
ChatMessage.cs
Database context:

ApplicationDbContext.cs – connects to Agriculture Energy DB
📦 Database Usage
We used Microsoft SQL Server as our backend, and named the database Agriculture Energy .

Sample Data Preloaded:
Farmers: Kate@gmail.com, RP@gmail.com
Products: Organic Tomatoes, Free-Range Eggs, etc.
Purchase Requests: Auto-generated when users request to buy a product
No manual seeding required — sample data is automatically handled during development via test login and CRUD operations. 

🎮 Feature Demonstration (Rubric-Focused)
1. Farmer Registration & Login
Users register via the built-in Identity system
After login, they're redirected to their dashboard
2. Product Browsing
Farmers can browse all available products from other farmers
Filter by name, email, or category
Clicking "Request to Purchase" sends a record to the PurchaseRequests table
3. Approving Purchase Requests
Farmers can view all incoming requests under /Purchase/ReceivedRequests
Approving a request marks it as approved in the database
4. Forum / Chat
Farmers can post messages and engage with others
Messages are stored in the ChatMessages table
5. Educational Resources
A dedicated page with links to:
Online courses
Webinars
Downloadable guides
Video tutorials
6. Profile Management
Farmers can view and edit their details
Accessed via dropdown menu in the top-right corner
🎨 User Interface Design
All pages follow a consistent, card-based layout using Bootstrap 5 and Font Awesome icons for a clean, professional look.

Enhancements:
Card hover effects for interactivity
Responsive grid layout for mobile compatibility
Consistent color scheme (green-themed for success actions)
Clear form validation and feedback
Easy-to-read typography using Segoe UI and Poppins
Icons were initially not working due to an extra space in the CDN URL. We've fixed that in the latest code:

html


1
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css " />
⚠️ Challenges and Changes
🛠️ Technical Challenges
Identity Dependency Issue
Initially had trouble with UserManager<IdentityUser> dependency injection
Fixed by using User.Identity.Name instead for quick access
Redirection Errors
Encountered localhost errors after approval
Solved by ensuring correct routing and using RedirectToAction("ReceivedRequests")
UI Responsiveness
Some cards and text broke on smaller screens
Resolved by applying d-flex, flex-wrap, and col-md-* classes
🔄 Design Changes
From Table Layout to Card Grids
Improved readability and mobile experience
Added hover animations and icons
Integrated Purchase Request Approval
Originally just managed in code — now visible and actionable in the UI
Added Full Navigation Bar with Icons
Made all navigation items clickable and accessible
🛠️ Setup Instructions
Prerequisites
Ensure you have the following installed:

.NET SDK 9.0
Visual Studio 2022 or VS Code
SQL Server Express
SQL Server Management Studio
1. Clone the Repository
bash


1
2
git clone https://github.com/ST10378552/AgriConnect.git 
cd AgriConnect
2. Configure the Database
Open SQL Server Management Studio
Create a new database named Agriculture Energy
Update connection string in appsettings.json:
json


1
2
3
⌄
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=Agriculture Energy;Trusted_Connection=True;MultipleActiveResultSets=true"
}
3. Apply Migrations
Using Package Manager Console:

powershell


1
2
Add-Migration InitialCreate
Update-Database
Or CLI:

bash


1
2
dotnet ef migrations add InitialCreate
dotnet ef database update
4. Build and Run the Application
In Visual Studio:

Open .sln file
Press F5 to run the app
In Command Line:

bash


1
2
dotnet build
dotnet run
App will run at https://localhost:7029/

🧪 Testing Credentials
Use these to test the app:

Farmer
Kate@gmail.com
Kate@123
Employee
Jones@gmail.com
Jones@123

Once logged in:

Farmers can go to /Purchase/Browse to see products
Employees can manage farmers/products from /Farmers/Index or /Products/Index
📝 Development Workflow
Project Structure Highlights
Controllers/ : Handles user input and logic
Models/ : Contains business logic and entity definitions
Views/ : Razor views organized per controller
Data/ : ApplicationDbContext handles database connections
wwwroot/ : Static assets (CSS, JS, images)
Extending the App
Want to add more features?

Extend existing controllers
Add new views inside Views/YourController/
Modify the database schema:
bash


1
2
dotnet ef migrations add NewFeatureMigration
dotnet ef database update
📄 License
This project is licensed under the MIT License – see the LICENSE file for details.

📞 Contact
For questions or support regarding this project, please reach out:

📧 Email : naidoodevesh32@gmail.com
🐱 GitHub : https://github.com/ST10378552/AgriConnect

🙌 Thank You!
Thank you for checking out AgriEnergyConnect – a platform that empowers farmers to share sustainable practices, trade green products, and learn about renewable energy solutions.
