using System;
using System.Collections.Generic;

namespace TMDT_Banmypham.Models
{
    public partial class GiohangNguoisudung
    {
        public string MaGh { get; set; }
        public string MaNsd { get; set; }

        public virtual Giohang MaGhNavigation { get; set; }
        public virtual Nguoisudung MaNsdNavigation { get; set; }
    }
}
