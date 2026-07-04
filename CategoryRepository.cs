using Demo_2_sun.Data;
using Demo_2_sun.Models;
using Demo_2_sun.Repositorys.Interfaces;

namespace Demo_2_sun.Repositorys.CLASSES
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Category AddCategory(Category category)
        {
            _context.categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public List<Category> GetAllCategories()
        {
            return _context.categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.categories.FirstOrDefault(c => c.CategoryId == id);
        }

        public Category GetCategoryByName(string name)
        {
            return _context.categories.FirstOrDefault(c => c.CategoryName == name);
        }

        public Category UpdateCategory(Category category)
        {
            _context.categories.Update(category);
            _context.SaveChanges();
            return category;
        }

        public void DeleteCategory(Category category)
        {
            _context.categories.Remove(category);
            _context.SaveChanges();
        }

        public bool CategoryExists(string categoryName)
        {
            return _context.categories.Any(c => c.CategoryName == categoryName);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
