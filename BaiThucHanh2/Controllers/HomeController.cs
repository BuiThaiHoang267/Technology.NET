using BaiThucHanh2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BaiThucHanh2.Controllers
{
    public class HomeController : Controller
    {
        private FastFoodManagementDbContext db = new FastFoodManagementDbContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

		public IActionResult Index()
        {
            var categories = db.Categories.ToList();
            return View("Index",categories);
        }

		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
