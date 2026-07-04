using Demo_2_sun.Models;

namespace Demo_2_sun.Repositorys.Interfaces
{
    public interface IProductRepository
    {
        Product AddProduct(Product product);

        List<Product> GetAllProducts();

        Product GetProductById(int id);

        Product UpdateProduct(Product product);

        void DeleteProduct(Product product);

        List<Product> SearchByName(string name);

        List<Product> SearchByCategory(string category);

        List<Product> SearchByBrand(string brand);

        List<Product> SearchByPriceRange(decimal minPrice, decimal maxPrice);

        List<Product> GetProductsWithPagination(int page, int pageSize);

        List<Product> SortByPrice(bool ascending);

        List<Product> SortByName();

        List<Product> SortByRating();

        List<Product> FilterByStock();

        List<Product> FilterActiveProducts();

        Product UpdateStock(int productId, int stock);

        bool ProductExists(int id);

        void SaveChanges();
    }
}
