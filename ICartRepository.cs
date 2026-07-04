using Demo_2_sun.Models;

namespace Demo_2_sun.Repositorys.Interfaces
{
    public interface ICartRepository
    {
        CartItem AddItemToCart(CartItem cartItem);

        List<CartItem> GetCartByUser(int userId);

        CartItem GetCartItemById(int id);

        CartItem UpdateQuantity(CartItem cartItem);

        void RemoveItem(CartItem cartItem);

        void ClearCart(int userId);

        bool CartExists(int userId);

        decimal GetTotalCartAmount(int userId);

        void SaveChanges();
    }
}
