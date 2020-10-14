using System;
using System.Collections.Generic;

namespace TMDT_Banmypham.Models
{
    public partial class Loaisanpham
    {
        public Loaisanpham()
        {
            Sanpham = new HashSet<Sanpham>();
        }

        public string MaLsp { get; set; }
        public string TenLsp { get; set; }

        public virtual ICollection<Sanpham> Sanpham { get; set; }
    }
}
