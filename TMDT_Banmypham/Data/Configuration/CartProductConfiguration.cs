
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMDT_Banmypham.Models.Configuration
{
    public class CartProductConfiguration : IEntityTypeConfiguration<CatalogProduct>
    {
        public void Configure(EntityTypeBuilder<CatalogProduct> builder)
        {
            builder.HasKey(x => x.IDCatalog);
            builder.ToTable("Loại Sản Phẩm");
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
