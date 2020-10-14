using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMDT_Banmypham.Models;

namespace TMDT_Banmypham.Data.Configuration
{
    public class CartConfiguration : IEntityTypeConfiguration<ProductinCart>
    {
        public void Configure(EntityTypeBuilder<ProductinCart> builder)
        {
            builder.HasKey(t => new {t.IDCart, t.IDProduct });
            builder.ToTable(" Sản phẩm trong giỏ hàng");
            builder.HasOne(t => t.Product).WithMany(pc => pc.ProductinCart)
                .HasForeignKey(pc => pc.IDProduct);
            builder.HasOne(t => t.Carts).WithMany(pc => pc.ProductinCatalogs)
             .HasForeignKey(pc => pc.IDCart);
        }
    }
}
