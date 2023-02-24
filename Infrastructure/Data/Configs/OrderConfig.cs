using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configs
{
    public class OrderConfig : IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            builder.ToTable("orders");
            builder.HasKey(x => x.Id);

            builder.HasOne(o => o.Product)
            .WithMany(p => p.Orders)
            .HasForeignKey(o => o.ProductId);

            builder.HasOne(o => o.RequestingUser)
            .WithMany(u => u.Orders)
            .HasForeignKey(o => o.RequestingUserId)
            .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(o => o.CourierUser)
            .WithMany()
            .HasForeignKey(o => o.CourierUserId)
            .OnDelete(DeleteBehavior.NoAction);
          
        }
    }
}
