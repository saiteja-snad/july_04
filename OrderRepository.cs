using Demo_2_sun.Data;
using Demo_2_sun.Models;
using Demo_2_sun.Repositorys.Interfaces;

namespace Demo_2_sun.Repositorys.CLASSES
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Order CreateOrder(Order order)
        {
            _context.orders .Add(order);
            return order;
        }

        public OrderItem AddOrderItem(OrderItem orderItem)
        {
            _context.ordersItems.Add(orderItem);
            return orderItem;
        }

        public List<Order> GetAllOrders()
        {
            return _context.orders.ToList();
        }

        public Order GetOrderById(int id)
        {
            return _context.orders.FirstOrDefault(o => o.OrderId == id);
        }

        public List<Order> GetOrdersByUser(int userId)
        {
            return _context.orders
                           .Where(o => o.UserId == userId)
                           .ToList();
        }

        public Order UpdateOrderStatus(Order order)
        {
            _context.orders.Update(order);
            return order;
        }

        public Order CancelOrder(Order order)
        {
            _context.orders.Update(order);
            return order;
        }

        public void DeleteOrder(Order order)
        {
            _context.orders.Remove(order);
        }

        public decimal CalculateTotalAmount(int orderId)
        {
            return _context.ordersItems
                           .Where(o => o.OrderId == orderId)
                           .Sum(o => o.Quantity * o.UnitPrice);
        }

        public string GenerateOrderNumber()
        {
            return "ORD" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}