
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMDT_Banmypham.Models
{
    public class ProductinCart
    {
        public int IDProduct { get; set; }
        public int IDCart { get; set; }
        public Product Product { get; set; }
        public Cart Carts{ get; set; }

    }
}
