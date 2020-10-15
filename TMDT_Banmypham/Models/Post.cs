using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TMDT_Banmypham.Models
{ 
    public class Post
    { 
        public int IDPost { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
    }
}
