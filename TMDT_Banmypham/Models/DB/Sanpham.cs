using System;
using System.Collections.Generic;

namespace TMDT_Banmypham.Models.DB
{
    public partial class Sanpham
    {
        public string MaSp { get; set; }
        public string TenSp { get; set; }
        public string ThuongHieu { get; set; }
        public decimal GiaSp { get; set; }
        public string MoTaSp { get; set; }
        public string Hinhanh { get; set; }
        public string MaLsp { get; set; }

        public virtual Loaisanpham MaLspNavigation { get; set; }
    }
}
