using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TechnoWebShop.Data.Models;

namespace TechnoWebShop.Data
{
    public class TechnoWebShopDbContext : IdentityDbContext<WebShopUser, IdentityRole, string>
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderStatus> OrderStatuses { get; set; }

        public DbSet<Receipt> Receipts { get; set; }
        public TechnoWebShopDbContext(DbContextOptions options) : base(options)
        {
            
        }

        
    }
}
