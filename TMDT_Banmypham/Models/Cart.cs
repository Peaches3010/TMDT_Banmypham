using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TMDT_Banmypham.Models
{
    public class Cart
    {
        [Key]
        public int  IDCart { get; set; }
        public int Price { set; get; }
        public int Quantity { set; get; }


        public List<ProductinCart> ProductinCatalogs { get; set; }
        public List <Product> Products { get; set; }
       public int IDProduct { set; get; }

    }
}
