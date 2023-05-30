using Microsoft.EntityFrameworkCore;

namespace MShopBackend.Models
{
    public class CartContext : DbContext
    {
        public CartContext(DbContextOptions<CartContext> options)
            : base(options)
        {
        }

        public DbSet<Cart> Cart { get; set; }
    }
}
