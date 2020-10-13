using eShopSolutionData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolutionData.EF
{
    public class eShopDBContext : DbContext
    {
        public eShopDBContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Products> Product { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Appconfig> Appconfigs  { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<CatalogProduct> catalogProducts { get; set; }


    }
}
