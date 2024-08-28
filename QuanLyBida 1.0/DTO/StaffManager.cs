using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanBida.DTO
{
    public class StaffManager
    {
        public class ChamCong
        {
            public int MaChamCong { get; set; }
            public int MaNhanVien { get; set; }
            public DateTime Ngay { get; set; }
            public TimeSpan GioVao { get; set; }
            public TimeSpan GioRa { get; set; }
        }


      
    }
}
