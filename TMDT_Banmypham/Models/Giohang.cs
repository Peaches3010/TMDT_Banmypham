using System;
using System.Collections.Generic;

namespace TMDT_Banmypham.Models
{
    public partial class Giohang
    {
        public Giohang()
        {
            GiohangNguoisudung = new HashSet<GiohangNguoisudung>();
            GiohangSanpham = new HashSet<GiohangSanpham>();
        }

        public string MaGh { get; set; }
        public decimal TongGia { get; set; }

        public virtual ICollection<GiohangNguoisudung> GiohangNguoisudung { get; set; }
        public virtual ICollection<GiohangSanpham> GiohangSanpham { get; set; }
    }
}
