namespace Demo_2_sun.DTOS
{
    public class UpdateCategoryDto
    {
        public string CategoryName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool IsActive { get; set; }
    }
}
