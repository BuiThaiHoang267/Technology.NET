using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SHOPTEST.Models;

namespace SHOPTEST.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly ShoptestContext _context;

        public ProductController(ShoptestContext context)
        {
            _context = context;
        }

        [HttpGet("bycategory/{categoryId:int}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductsByCategory(int categoryId)
        {
            var products = await _context.Products.Where(p => p.CategoryId == categoryId).ToListAsync();
            if (!products.Any()) return NotFound();
            return Ok(products);
        }

        //Get by ID
        [HttpGet("byid/{id:int}")]
        public async Task<ActionResult<Product>> GetProductsById(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        //Get all
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var products = await _context.Products
            .Include(p => p.Category)
            .Select(p => new
            {
                p.Id,
                p.Name,
                p.Price,
                p.Img,
                p.CategoryId,
                p.Description,
                CategoryName = p.Category.Name,
            })
            .ToListAsync();

            return Ok(products);
        }

        //Update
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] Product updatedProduct)
        {
            // Tìm sản phẩm theo id
            var product = await _context.Products.FindAsync(id);

            // Kiểm tra nếu sản phẩm không tồn tại
            if (product == null)
            {
                return NotFound(new { message = "Product not found." });
            }

            // Cập nhật các thuộc tính của sản phẩm
            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;
            product.Description = updatedProduct.Description;

            try
            {
                // Lưu thay đổi vào database
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, new { message = "An error occurred while updating the product." });
            }

            return NoContent();
        }

        //Delete Product
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound(new { message = "Product not found." });
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateProduct([FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
