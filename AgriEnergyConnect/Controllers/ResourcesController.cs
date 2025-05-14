
using Microsoft.AspNetCore.Mvc;

namespace AgriEnergyConnect.Controllers
{
    public class ResourcesController : Controller
    {
        // GET: /Resources/Index
        public IActionResult Index()
        {
            return View();
        }
    }
}
