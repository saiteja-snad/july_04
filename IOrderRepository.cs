using Demo_2_sun.Models;

namespace Demo_2_sun.Repositorys.Interfaces
{
    public interface IOrderRepository
    {
        Order CreateOrder(Order order);

        OrderItem AddOrderItem(OrderItem orderItem);

        List<Order> GetAllOrders();

        Order GetOrderById(int id);

        List<Order> GetOrdersByUser(int userId);

        Order UpdateOrderStatus(Order order);

        Order CancelOrder(Order order);

        void DeleteOrder(Order order);

        decimal CalculateTotalAmount(int orderId);

        string GenerateOrderNumber();

        void SaveChanges();
    }
}
