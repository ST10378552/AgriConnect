using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using AgriEnergyConnect.Data;
using AgriEnergyConnect.Models;

namespace AgriEnergyConnect.Controllers
{
    public class PostController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<PostController> _logger;

        public PostController(ApplicationDbContext context, ILogger<PostController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: /Post/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Post/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Post post)
        {
            _logger.LogInformation("Attempting to create a new post.");

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Model state is invalid.");
                foreach (var key in ModelState.Keys)
                {
                    var state = ModelState[key];
                    if (state.Errors.Count > 0)
                    {
                        _logger.LogWarning($"Validation error on '{key}': {state.Errors[0].ErrorMessage}");
                    }
                }
                return View(post);
            }

            try
            {
                post.CreatedOn = DateTime.Now;
                _context.Posts.Add(post);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Post successfully created.");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while saving the post.");
                ModelState.AddModelError("", "Unable to save your post. Please try again later.");
                return View(post);
            }
        }

        // GET: /Post/Index
        public async Task<IActionResult> Index()
        {
            var posts = await _context.Posts.OrderByDescending(p => p.CreatedOn).ToListAsync();
            return View(posts);
        }
    }
}