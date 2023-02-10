using Domain.Entities;
using Infrastructure.Data.Configs;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new OrderConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
        }

        public DbSet<UserEntity> UserEntity { get; set; }
        public DbSet<ProductEntity> ProductEntity { get; set; }
        public DbSet<OrderEntity> OrderEntity { get; set; }

    }
}
