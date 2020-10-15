
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMDT_Banmypham.Models.Configuration
{
    public class IngredientConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.ToTable("Thành Phần");
            builder.HasKey(x => x.IDIngredient);
            builder.HasOne(x => x.Product).WithMany(x => x.Ingredients).HasForeignKey(x => x.IDProduct);
        }
    }
}
