using Demo_2_sun.Models;

namespace Demo_2_sun.Repositorys.Interfaces
{
    public interface ICategoryRepository
    {
        Category AddCategory(Category category);

        List<Category> GetAllCategories();

        Category GetCategoryById(int id);

        Category GetCategoryByName(string name);

        Category UpdateCategory(Category category);

        void DeleteCategory(Category category);

        bool CategoryExists(string categoryName);

        void SaveChanges();
    }
}
