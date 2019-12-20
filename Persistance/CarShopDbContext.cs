using CarShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Persistance
{
    public class CarShopDbContext: DbContext
    {
        
        public CarShopDbContext(DbContextOptions<CarShopDbContext> options)
            :base(options)
        {
        }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}