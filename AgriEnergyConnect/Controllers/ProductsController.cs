using AgriEnergyConnect.Data;
using AgriEnergyConnect.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AgriEnergyConnect.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProductsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // 👇 This is where your new Index() method goes
        [HttpGet]
        public async Task<IActionResult> Index(
    string productName,
    string farmerEmail,
    string category)
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            IQueryable<Product> productsQuery = _context.Products;

            // Filter by role
            if (User.IsInRole("Farmer"))
            {
                var farmer = await _context.Farmers
                    .FirstOrDefaultAsync(f => f.Email.ToLower() == user.Email.ToLower());

                if (farmer == null)
                {
                    return RedirectToAction("Create", "Farmers");
                }

                // Farmer only sees their own products
                productsQuery = productsQuery
                    .Where(p => p.FarmerEmail.ToLower() == user.Email.ToLower());
            }
            else if (User.IsInRole("Employee"))
            {
                // Employee can see all products
                productsQuery = productsQuery;
            }
            else
            {
                return Forbid();
            }

            // Apply filters
            if (!string.IsNullOrEmpty(productName))
            {
                productsQuery = productsQuery.Where(p => p.Name.Contains(productName));
            }

            if (!string.IsNullOrEmpty(farmerEmail))
            {
                productsQuery = productsQuery.Where(p => p.FarmerEmail.Contains(farmerEmail));
            }

            if (!string.IsNullOrEmpty(category))
            {
                productsQuery = productsQuery.Where(p => p.Category.Contains(category));
            }

            // Pass filter values back to view
            ViewData["ProductNameFilter"] = productName;
            ViewData["FarmerEmailFilter"] = farmerEmail;
            ViewData["CategoryFilter"] = category;

            return View(await productsQuery.ToListAsync());
        }
        // Other methods like Create, Edit, Delete below...


        // GET: Products/Create
        [Authorize(Roles = "Farmer")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Farmer")]
        public async Task<IActionResult> Create([Bind("Name,Category,ProductionDate,Description,FarmerEmail")] Product product)
        {
            var user = await _userManager.GetUserAsync(User);
            var farmer = await _context.Farmers
                .FirstOrDefaultAsync(f => f.Email.ToLower() == user.Email.ToLower());

            if (farmer == null)
            {
                ModelState.AddModelError("", "You must create a farmer profile before adding products.");
                return View(product);
            }

            if (ModelState.IsValid)
            {
                product.FarmerEmail = user.Email; // Set logged-in user's email
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(product);
        }

        // GET: Products/Edit/5
        // GET: Products/Edit/5
        [Authorize(Roles = "Farmer")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var product = await _context.Products.FindAsync(id);
            if (product == null) return NotFound();

            var user = await _userManager.GetUserAsync(User);

            if (!await CanEditProduct(product, user))
            {
                return Forbid();
            }

            return View(product);
        }

        private async Task<bool> CanEditProduct(Product product, ApplicationUser user)
        {
            if (user == null || string.IsNullOrEmpty(product.FarmerEmail)) return false;

            return product.FarmerEmail.ToLower() == user.Email.ToLower();
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Farmer")]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,Name,Category,ProductionDate,Description")] Product product)
        {
            if (id != product.ProductId) return NotFound();

            var user = await _userManager.GetUserAsync(User);
            var farmer = await _context.Farmers.FirstOrDefaultAsync(f => f.Email == user.Email);

            if (farmer == null || product.FarmerEmail != farmer.Email)
            {
                return Forbid();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            return View(product);
        }

        // GET: Products/Delete/5
        [Authorize(Roles = "Farmer")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ProductId == id);

            if (product == null)
            {
                return NotFound();
            }

            var user = await _userManager.GetUserAsync(User);
            var farmer = await _context.Farmers.FirstOrDefaultAsync(f => f.Email == user.Email);

            if (farmer == null || product.FarmerEmail != farmer.Email)
            {
                return Forbid();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Farmer")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            var user = await _userManager.GetUserAsync(User);
            var farmer = await _context.Farmers.FirstOrDefaultAsync(f => f.Email == user.Email);

            if (farmer == null || product.FarmerEmail != farmer.Email)
            {
                return Forbid();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}