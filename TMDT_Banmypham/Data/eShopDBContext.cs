using eShopSolutionData.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TMDT_Banmypham.Data.Configuration;
using TMDT_Banmypham.Models.Configuration;
using TMDT_Banmypham.Models;

namespace eShopSolutionData.EF
{
    public class eShopDBContext : DbContext
    {
        public eShopDBContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Appconfiguration());
            modelBuilder.ApplyConfiguration(new ProductsConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new CartProductConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new IngredientConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Cart> Categories { get; set; }
        public DbSet<Appconfig> Appconfigs  { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<CatalogProduct> catalogProducts { get; set; }


    }
}
