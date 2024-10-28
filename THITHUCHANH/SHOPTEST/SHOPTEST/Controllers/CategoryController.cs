using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SHOPTEST.Models;

namespace SHOPTEST.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ShoptestContext _context;

        public CategoryController(ShoptestContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
