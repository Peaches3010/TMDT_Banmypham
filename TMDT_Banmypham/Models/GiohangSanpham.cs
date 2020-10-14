using System;
using System.Collections.Generic;

namespace TMDT_Banmypham.Models
{
    public partial class GiohangSanpham
    {
        public string MaGh { get; set; }
        public string MaSp { get; set; }
        public int SoLuong { get; set; }

        public virtual Giohang MaGhNavigation { get; set; }
        public virtual Sanpham MaSpNavigation { get; set; }
    }
}
