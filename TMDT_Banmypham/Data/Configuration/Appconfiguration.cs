
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TMDT_Banmypham.Models;

namespace eShopSolutionData.Configuration
{
    public class Appconfiguration : IEntityTypeConfiguration<Appconfig>
    { 
        public void Configure(EntityTypeBuilder<Appconfig> builder)
        {
            builder.HasKey(x => x.Key);
            builder.Property(x => x.Value);
        }
    }
}
