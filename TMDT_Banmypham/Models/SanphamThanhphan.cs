using System;
using System.Collections.Generic;

namespace TMDT_Banmypham.Models
{
    public partial class SanphamThanhphan
    {
        public string MaSp { get; set; }
        public string MaTp { get; set; }

        public virtual Sanpham MaSpNavigation { get; set; }
        public virtual Thanhphan MaTpNavigation { get; set; }
    }
}
