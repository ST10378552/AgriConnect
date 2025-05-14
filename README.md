🌱 Agri-Energy Connect 🔋
<div align="center">

ASP.NET Core

C#

SQL Server

Bootstrap

<h3>Sustainable Agriculture Meets Green Energy</h3>

<p>A modern platform connecting sustainable farmers with renewable energy solutions</p>
</div>

📝 Project Overview
Agri-Energy Connect is a web-based platform designed to bridge the gap between sustainable agriculture and green energy solutions in South Africa. The platform connects farmers with energy experts, facilitating knowledge sharing, resource access, and collaboration opportunities to promote sustainable farming practices and renewable energy adoption.

Who It's For
Farmers : Agricultural producers looking to manage their profiles, products, and engage with other farmers.
Employees : System administrators managing farmer accounts, product listings, and overall platform operations.
Architecture & Design Patterns
The application follows the Model-View-Controller (MVC) pattern, leveraging ASP.NET Core for robust backend functionality and Bootstrap 5 for responsive frontend design. Entity Framework Core is used for database interactions, ensuring efficient data management.

Database Choice
We chose Microsoft SQL Server as the database due to its reliability, scalability, and seamless integration with ASP.NET Core. SQL Server provides robust features like transaction support, security, and ease of use for both development and production environments.

🛠️ Key Features
User Authentication
Secure login and role-based access control using ASP.NET Identity.
Password hashing ensures user credentials are stored securely.
Farmer Profiles
Detailed farmer information including farm details, contact information, and location.
Farmers can manage their profiles, update personal details, and view their product listings.
Product Marketplace
Platform for farmers to showcase their sustainable agricultural products.
Employees can manage all product listings across the platform.
Responsive Design
Built with Bootstrap 5 to ensure a mobile-friendly interface.
Font icons from FontAwesome enhance usability and visual appeal.
Data Management
Entity Framework Core handles CRUD operations efficiently.
SQL Server serves as the backend database, providing reliable data storage and retrieval.
🚀 User Roles
The platform supports two primary user roles:

Employee
Responsibilities :
Manage farmer accounts and profiles.
View all products across the platform.
Access detailed farmer information and performance metrics.
Farmer
Capabilities :
Manage their profile and farm details.
Add, edit, and delete their product listings.
View products from other farmers and request purchases.
💻 Technology Stack
Framework : ASP.NET Core MVC
Frontend : HTML5, CSS3, JavaScript, Bootstrap 5
Backend : C#, Entity Framework Core
Database : Microsoft SQL Server
Authentication : ASP.NET Identity with password hashing
Styling : FontAwesome Icons, Google Fonts (Poppins, Inter)
🏁 Setup Instructions
Prerequisites
Ensure you have the following installed:

.NET SDK
Visual Studio 2022 or Visual Studio Code
SQL Server (Express edition sufficient for development)
SQL Server Management Studio
Clone the Repository
bash


1
2
git clone https://github.com/ST10378552/AgriConnect
cd AgriEnergyConnects
Database Configuration
Open SQL Server Management Studio.
Create a new database named AgricultureEnergy.
Update the connection string in appsettings.json:
json


1
2
3
⌄
"ConnectionStrings": {
  "DefaultConnection": "Server=DEVESH\\SQLEXPRESS;Database=AgricultureEnergy;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
}
Apply Database Migrations
Run the following commands:

bash


1
2
dotnet ef migrations add InitialCreate
dotnet ef database update
Build and Run the Application
Using Visual Studio:
Open the solution file (AgriEnergyConnects.sln).
Build the solution (Ctrl+Shift+B).
Press F5 to run the application.
Using the Command Line:
bash


1
2
dotnet build
dotnet run
The application should now be running at https://localhost:7066/.

🎮 Using the Application
Landing Page
Provides a welcome screen with links to Login and Register pages.
Authentication
Use demo credentials:
Employee : Email: Khan@gmail.com, Password: Khan@123
Farmer : Email: Kate@gmail.com, Password: Kate@123
Dashboard
After successful registration or login, users are redirected to the Home page.
Navigation bar dynamically updates based on the user's role.
For Employees
Managing Farmers
Navigate to the "Farmers" section to view registered farmers.
Add new farmers using the "Create New" button.
View detailed farmer profiles by clicking "Details."
Delete farmer profiles by clicking "Delete."
Viewing Products
Access the "All Products" section to browse products from all farmers.
Filter products by category or date range.
For Farmers
Managing Profile
Access your profile from the "Farmers Profile" tab.
Edit/update your profile information using the "Save Changes" button.
Managing Products
Navigate to "Products" to view current product listings.
Add new products using the "Create New Product" button.
Edit, view, or delete existing products.
Forum/Farmers Chat
Navigate to the "Farmers Chat" to chat with other farmers.
Send messages to the community.
🛠️ Development Workflow
Project Structure
The application follows the standard ASP.NET Core MVC structure:

Controllers/
Handles application logic.
Example: FarmersController.cs, ProductsController.cs.
Models/
Represents data entities.
Example: Farmer.cs, Product.cs.
Views/
Contains views organized by controller.
Example: Farmers/, Products/.
Data/
Contains database context and configurations.
Example: ApplicationDbContext.cs.
wwwroot/
Static files like CSS, JS, images, and libraries.
Extending the Application
Adding New Features
Create new controllers and corresponding views.
Update navigation in _Layout.cshtml.
Modifying Database Schema
Update model classes.
Create migrations:
bash


1
2
dotnet ef migrations add MigrationName
dotnet ef database update
🧪 Testing
The application includes sample data for testing:

Sample Users
Employee: Email: employee1@gmail.com, Password: password123
Farmers: Email: farmer1@gmail.com, Password: password123; Email: farmer2@gmail.com, Password: password123
Sample Products
Organic Tomatoes
Free-Range Eggs
Grass-Fed Beef
Honey
Organic Spinach
📜 License
This project is licensed under the MIT License - see the LICENSE file for details.

📞 Contact
For questions or support:

Email: naidoodevesh32@gmail.com
GitHub: ST10378552
Thank you for using Agri-Energy Connect! We hope this platform contributes to more sustainable farming practices and broader adoption of renewable energy solutions in agriculture.
