using Demo_2_sun.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Demo_2_sun.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

       public DbSet<Order> orders { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<RefreshToken> refreshTokens { get; set; }
        public DbSet<CartItem> cartItems { get; set; }
        public DbSet<OrderItem> ordersItems { get; set; }
        public DbSet<Review> reviews { get; set; }

    }
}
