using BaiThucHanh2.Models;

namespace BaiThucHanh2.ViewModel
{
	public class ThucDonViewModel
	{
		public IEnumerable<Product> products { get; set; }

		public ThucDonViewModel()
		{
			products = new List<Product>();
		}
	}
}
