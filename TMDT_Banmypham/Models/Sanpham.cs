using System;
using System.Collections.Generic;

namespace TMDT_Banmypham.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            GiohangSanpham = new HashSet<GiohangSanpham>();
            SanphamThanhphan = new HashSet<SanphamThanhphan>();
        }

        public string MaSp { get; set; }
        public string TenSp { get; set; }
        public string ThuongHieu { get; set; }
        public decimal GiaSp { get; set; }
        public string MoTaSp { get; set; }
        public string DatSp { get; set; }
        public string MaLsp { get; set; }

        public virtual Loaisanpham MaLspNavigation { get; set; }
        public virtual ICollection<GiohangSanpham> GiohangSanpham { get; set; }
        public virtual ICollection<SanphamThanhphan> SanphamThanhphan { get; set; }
    }
}
