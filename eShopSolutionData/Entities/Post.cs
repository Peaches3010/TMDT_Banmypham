using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eShopSolutionData.Entities
{
    public class Post
    { 
        [Key]
        public int IDPost { get; set; }
        [Required]
        public string Title { get; set; }
        public string Discription { get; set; }
    }
}
