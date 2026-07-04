namespace Demo_2_sun.DTOS
{
    public class AddReviewDto
    {
        public int ProductId { get; set; }

        public int Rating { get; set; }

        public string Comment { get; set; } = string.Empty;
    }
}
