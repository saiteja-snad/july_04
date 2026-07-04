namespace Demo_2_sun.Models
{
    public class Role
    {
        public int RoleId { get; set; }

        public string RoleName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
