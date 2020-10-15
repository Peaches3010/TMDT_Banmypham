using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TMDT_Banmypham.Models;

namespace TMDT_Banmypham.Models
{
    public class Product
    { 
        public int IDProduct { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
       
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime Date { get; set; }


        public CatalogProduct Catalog { get; set; }
        public List<ProductinCart> ProductinCart { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public Cart Carts { get; set; }
    }
}
