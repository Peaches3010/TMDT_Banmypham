using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eShopSolutionData.Entities
{
    [Table("Sản Phẩm")]
    public class Products
    {
        [DisplayName ("Mã Sản Phẩm") ]
        [Key]
        public int IDProduct { get; set; }
        [Required]
        [Column(TypeName = "Money")]
        public decimal Price { get; set; }
        public string Status { get; set; }
        [Required]
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public CatalogProduct Catalog { get; set; }
    }
}
