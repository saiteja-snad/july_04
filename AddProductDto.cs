namespace Demo_2_sun.DTOS
{
    public class AddProductDto
    {
        public string ProductName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Brand { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public string SKU { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public int CategoryId { get; set; }
    }
}
