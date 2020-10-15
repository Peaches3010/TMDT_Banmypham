
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TMDT_Banmypham.Models;

namespace eShopSolutionData.Configuration
{
    public class ProductsConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.IDProduct);
            builder.ToTable("Sản Phẩm");
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.Date).IsRequired();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200).HasColumnType("nvarchar");
            builder.HasOne(x => x.Carts).WithMany(x => x.Products).HasForeignKey(x => x.IDProduct);
        }
    }
}
