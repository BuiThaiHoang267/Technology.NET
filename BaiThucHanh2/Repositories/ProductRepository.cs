using BaiThucHanh2.Models;

namespace BaiThucHanh2.Repositories
{
	public interface IProductRepository
	{
		IEnumerable<Product> GetByCategoryId(int id);
	}
	public class ProductRepository : IProductRepository
	{
		private FastFoodManagementDbContext _context = default!;
		public ProductRepository(FastFoodManagementDbContext context)
		{
			_context = context;
		}
		public IEnumerable<Product> GetByCategoryId(int id)
		{
			ICollection<Product> products = _context.Products.Where(x => x.CategoryId == id).ToList();
			return products;
		}
	}
}
