using BaiThucHanh2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BaiThucHanh2.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryViewComponent(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.GetAll().OrderBy(x => x.Id);
            return View(categories);
        }
    }
}
