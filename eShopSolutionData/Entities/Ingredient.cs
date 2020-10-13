using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eShopSolutionData.Entities
{
   public class Ingredient
    {
        [Key]
        public int IDIngredient { get; set; }
        public int Rated { get; set; }
        [Required]
        public int Name { get; set; }
        public DateTime DateWrite { get; set; }
        public string Discription{ get; set; }

    }
}
