namespace Demo_2_sun.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }

        public int UserId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public DateTime AddedAt { get; set; }
    }
}