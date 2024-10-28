using BaiThucHanh2.Models;
using BaiThucHanh2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BaiThucHanh2.ViewComponents
{
	public class ProductViewComponent: ViewComponent
	{
		private readonly IProductRepository _productRepository;
		public ProductViewComponent(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}
		public IViewComponentResult Invoke(IEnumerable<Product> products)
		{
			return View(products);
		}
	}
}
