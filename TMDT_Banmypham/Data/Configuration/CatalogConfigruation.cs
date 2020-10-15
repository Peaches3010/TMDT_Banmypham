
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMDT_Banmypham.Models.Configuration
{
    public class CatalogConfigruation : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Giỏ Hàng");

            builder.HasKey(x => x.IDCart);

            builder.Property(x => x.IDCart).UseIdentityColumn();
        }
    }
}
