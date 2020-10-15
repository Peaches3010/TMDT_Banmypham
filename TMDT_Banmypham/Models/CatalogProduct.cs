using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TMDT_Banmypham.Models;

namespace TMDT_Banmypham.Models
{
   public class CatalogProduct
    {
        public int IDCatalog { get; set; }
        public string Name { get; set;}

        public List<Product> Products { get; set; }
    }
}
