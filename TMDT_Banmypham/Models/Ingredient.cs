using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TMDT_Banmypham.Models
{
   public class Ingredient
    {   
        public int IDIngredient { get; set; }
        public int Rated { get; set; }
        public int Name { get; set; }
        public DateTime DateWrite { get; set; }
        public string Discription{ get; set; }


        public Product Product { get; set; }
        public int IDProduct { get; set; }
    }
}
