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
    public class FarmersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public FarmersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Farmers
        [Authorize(Roles = "Employee")]
        public async Task<IActionResult> Index(string searchString, string locationFilter)
        {
            var farmers = from f in _context.Farmers select f;

            if (!String.IsNullOrEmpty(searchString))
            {
                farmers = farmers.Where(f => f.FullName.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(locationFilter))
            {
                farmers = farmers.Where(f => f.Location.Contains(locationFilter));
            }

            return View(await farmers.ToListAsync());
        }

        // GET: Farmers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var farmer = await _context.Farmers.FirstOrDefaultAsync(m => m.Id == id);
            if (farmer == null) return NotFound();

            var user = await _userManager.GetUserAsync(User);

            if (User.IsInRole("Employee") || (User.IsInRole("Farmer") && farmer.Email == user.Email))
            {
                return View(farmer);
            }

            return Forbid();
        }

        // GET: Farmers/Create
        [Authorize(Roles = "Employee")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Farmers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Employee")]
        public async Task<IActionResult> Create([Bind("Id,FullName,PhoneNumber,Email,Location,FarmSize,YearsOfExperience")] Farmer farmer)
        {
            var user = await _userManager.GetUserAsync(User);
            farmer.Email = user.Email; // Auto-link email to user

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(farmer);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "An error occurred while saving the farmer: " + ex.Message);
                }
            }
            return View(farmer);
        }

        // GET: Farmers/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var farmer = await _context.Farmers.FindAsync(id);
            if (farmer == null) return NotFound();

            var user = await _userManager.GetUserAsync(User);

            if (User.IsInRole("Employee") || (User.IsInRole("Farmer") && farmer.Email == user.Email))
            {
                return View(farmer);
            }

            return Forbid();
        }

        // POST: Farmers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,PhoneNumber,Email,Location,FarmSize,YearsOfExperience")] Farmer farmer)
        {
            if (id != farmer.Id) return NotFound();

            var user = await _userManager.GetUserAsync(User);

            if (!(User.IsInRole("Employee") || (User.IsInRole("Farmer") && farmer.Email == user.Email)))
            {
                return Forbid();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(farmer);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FarmerExists(farmer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        ModelState.AddModelError("", "The record you attempted to edit was modified by another user. Please refresh and try again.");
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "An error occurred while updating the farmer: " + ex.Message);
                }
            }
            return View(farmer);
        }

        // GET: Farmers/Delete/5
        [Authorize(Roles = "Employee")]
        public async Task<IActionResult> Delete(int? id, bool? concurrencyError)
        {
            if (id == null) return NotFound();

            var farmer = await _context.Farmers.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id);
            if (farmer == null)
            {
                if (concurrencyError.GetValueOrDefault())
                {
                    return RedirectToAction(nameof(Index));
                }
                return NotFound();
            }

            if (concurrencyError.GetValueOrDefault())
            {
                ViewData["ConcurrencyErrorMessage"] = "The record you attempted to delete was modified by another user. Please try again.";
            }

            return View(farmer);
        }

        // POST: Farmers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Employee")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var farmer = await _context.Farmers.FindAsync(id);
                if (farmer == null) return RedirectToAction(nameof(Index));

                _context.Farmers.Remove(farmer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                return RedirectToAction(nameof(Delete), new { concurrencyError = true });
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "An error occurred while deleting the farmer: " + ex.Message);
                var farmer = await _context.Farmers.FindAsync(id);
                return View(farmer);
            }
        }

        private bool FarmerExists(int id)
        {
            return _context.Farmers.Any(e => e.Id == id);
        }
    }
}