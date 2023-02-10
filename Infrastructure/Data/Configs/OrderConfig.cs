using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Configs
{
    public class OrderConfig : IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            builder.ToTable("orders");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Product).WithMany().HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.NoAction).IsRequired(false);
            builder.HasOne(x => x.RequestingUser).WithMany().HasForeignKey(x => x.RequestingUserId).OnDelete(DeleteBehavior.NoAction).IsRequired(false);
            builder.HasOne(x => x.CourierUser).WithMany().HasForeignKey(x => x.CourierUserId).OnDelete(DeleteBehavior.NoAction).IsRequired(false);

        }
    }
}
