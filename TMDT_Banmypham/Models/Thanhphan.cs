using System;
using System.Collections.Generic;

namespace TMDT_Banmypham.Models
{
    public partial class Thanhphan
    {
        public Thanhphan()
        {
            SanphamThanhphan = new HashSet<SanphamThanhphan>();
        }

        public string MaTp { get; set; }
        public string TenTp { get; set; }
        public string MoTaTp { get; set; }
        public int Mdat { get; set; }

        public virtual ICollection<SanphamThanhphan> SanphamThanhphan { get; set; }
    }
}
