using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eShopSolutionData.Entities
{
   public class CatalogProduct
    {
        [Key]
        public int IDCatalog { get; set; }
        [Required]
        public string Name { get; set;}
    }
}
