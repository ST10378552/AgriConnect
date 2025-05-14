using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading.Tasks;
using AgriEnergyConnect.Models;
using AgriEnergyConnect.Data;
using System.Security.Claims;

namespace AgriEnergyConnect.Controllers
{
    [Authorize]
    public class PurchaseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PurchaseController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Purchase/Browse
        public async Task<IActionResult> Browse(string productName, string farmerEmail, string category)
        {
            var userEmail = User.Identity?.Name;

            if (userEmail == null)
            {
                return Challenge(); // Force login
            }

            IQueryable<Product> productsQuery = _context.Products;

            // Exclude current farmer's own products
            productsQuery = productsQuery.Where(p => p.FarmerEmail.ToLower() != userEmail.ToLower());

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

            ViewData["ProductNameFilter"] = productName;
            ViewData["FarmerEmailFilter"] = farmerEmail;
            ViewData["CategoryFilter"] = category;

            return View(await productsQuery.ToListAsync());
        }

        // POST: /Purchase/Request
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Request(int productId)
        {
            var userEmail = User.Identity?.Name;

            if (userEmail == null)
            {
                return Challenge(); // Force login
            }

            var product = await _context.Products.FindAsync(productId);

            if (product == null) return NotFound();

            var request = new PurchaseRequest
            {
                ProductId = product.ProductId,
                RequestingFarmerEmail = userEmail
            };

            _context.PurchaseRequests.Add(request);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Your request has been sent to the farmer.";
            return RedirectToAction("Browse");
        }

        // GET: /Purchase/ReceivedRequests
        public async Task<IActionResult> RecievedRequests()
        {
            var userEmail = User.Identity?.Name;

            if (userEmail == null)
            {
                return Challenge();
            }

            // Get all products that belong to this farmer
            var farmerProducts = await _context.Products
                .Where(p => p.FarmerEmail.ToLower() == userEmail.ToLower())
                .Select(p => p.ProductId)
                .ToListAsync();

            // Get all purchase requests for those products
            var requests = await _context.PurchaseRequests
                .Where(r => farmerProducts.Contains(r.ProductId) && !r.IsApproved)
                .Include(r => r.Product)
                .ToListAsync();

            return View(requests);
        }

        // POST: /Purchase/ApproveRequest
        // POST: /Purchase/ApproveRequest
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ApproveRequest(int id)
        {
            var request = await _context.PurchaseRequests.FindAsync(id);

            if (request == null)
            {
                return NotFound();
            }

            request.IsApproved = true;
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Purchase request approved.";
            return RedirectToAction("RecievedRequests"); // Ensure this redirects to the correct action
        }
    }
}