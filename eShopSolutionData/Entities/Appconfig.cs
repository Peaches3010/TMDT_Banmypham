using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eShopSolutionData.Entities
{
    public class Appconfig
    { 
        [Key]
        public int Key { get; set; }
        [Required]
        public string Values { get; set; }
    }
}
