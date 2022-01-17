using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SportsStore.Models {
    public class StoreDbContext : DbContext {

        public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<NewsEkle> NewsEkle { get; internal set; }
    }
}
