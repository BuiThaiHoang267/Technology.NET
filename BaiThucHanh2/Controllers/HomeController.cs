using BaiThucHanh2.Models;
using BaiThucHanh2.ViewModel;
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
            ThucDonViewModel thucDonViewModel = new ThucDonViewModel();
            thucDonViewModel.products = db.Products.Where(p => p.CategoryId == 2).ToList();
            return View("Index",thucDonViewModel);
        }

        public IActionResult ProductByCategory(int categoryId)
        {
            ThucDonViewModel thucDonViewModel = new ThucDonViewModel();
            thucDonViewModel.products = db.Products.Where(p => p.CategoryId == categoryId).ToList();
            return View("Index",thucDonViewModel);
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
