using BaiThucHanh2.Models;

namespace BaiThucHanh2.Repositories
{
    public interface ICategoryRepository
    {
        Category GetByID(int id);
        IEnumerable<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        void Delete(int id);

	}
    public class CategoryRepository : ICategoryRepository
    {
        private FastFoodManagementDbContext _context = default!;
        public CategoryRepository(FastFoodManagementDbContext context)
        {
            _context = context;
        }
        public void Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Categories.Remove(GetByID(id));
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            ICollection<Category> categories = _context.Categories.ToList();
            return categories;
        }

        public Category GetByID(int id)
        {
            Category category = _context.Categories.Find(id)!;
            return category;
        }

        public void Update(Category category)
        {
            Category categoryToUpdate = _context.Categories.Find(category.Id)!;
            categoryToUpdate.Name = category.Name;
            categoryToUpdate.Image = category.Image;
            categoryToUpdate.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
        }
	}
}
