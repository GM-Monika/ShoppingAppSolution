using Microsoft.EntityFrameworkCore;

namespace ShiningShoppingApp.Context
{
    public class UserContext :DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }
        public DbSet<Models.Login> Login { get; set; } = null!;
        public DbSet<Models.Users> Users { get; set; } = null!;
        public DbSet<Models.CartProducts> CartProduct { get; set; } = null!;
        public DbSet<Models.Cart>CartDetails { get; set; } = null!;
        public DbSet<Models.Orders> OrderDetails { get; set; } = null!;
        public DbSet<Models.Product> ProductDetails { get; set; } = null!;

    }
}
