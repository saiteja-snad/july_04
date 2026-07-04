namespace Demo_2_sun.Models
{
    public class RefreshToken
    {
        public int RefreshTokenId { get; set; }

        public string Token { get; set; } = string.Empty;

        public DateTime ExpiresAt { get; set; }

        public bool IsRevoked { get; set; }

        public DateTime CreatedAt { get; set; }

        public int UserId { get; set; }
    }
}
