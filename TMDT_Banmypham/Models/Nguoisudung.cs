using System;
using System.Collections.Generic;

namespace TMDT_Banmypham.Models
{
    public partial class Nguoisudung
    {
        public Nguoisudung()
        {
            GiohangNguoisudung = new HashSet<GiohangNguoisudung>();
        }

        public string MaNsd { get; set; }
        public string TenNsd { get; set; }
        public DateTime NgaySinh { get; set; }
        public int Sdt { get; set; }
        public string Diachi { get; set; }
        public string TaiKhoanNsd { get; set; }
        public string MatKhauNsd { get; set; }

        public virtual ICollection<GiohangNguoisudung> GiohangNguoisudung { get; set; }
    }
}
