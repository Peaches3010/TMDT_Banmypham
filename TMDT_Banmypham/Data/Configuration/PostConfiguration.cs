using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMDT_Banmypham.Models.Configuration
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Bài Viết");
            builder.HasKey(x => x.IDPost);
            builder.Property(x => x.Title).HasColumnType("nvarchar").HasMaxLength(200);
            builder.Property(x => x.Discription).HasColumnType("text");
        }
    }
}
