namespace Demo_2_sun.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public string OrderNumber { get; set; } = string.Empty;

        public int UserId { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalAmount { get; set; }

        public string OrderStatus { get; set; } = string.Empty;

        public string PaymentStatus { get; set; } = string.Empty;

        public string ShippingAddress { get; set; } = string.Empty;

        public DateTime ExpectedDeliveryDate { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}