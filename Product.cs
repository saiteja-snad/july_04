namespace Demo_2_sun.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Brand { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public string SKU { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public int CategoryId { get; set; }
    }
}
