using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationSortApp
{
    class Movement
    {
        public enum LoaiDiChuyen
        {
            //Nút lệnh 1 tại vt1 đi lên, qua phải, đi xuông
            //Nút lệnh 2 đi xuống, qua trái, đi lên
            //tạo hành động cho nút lệnh di chuyển
            DI_LEN_DI_XUONG, QUA_PHAI_QUA_TRAI, DI_XUONG_DI_LEN, DUNG
        }
        //vị trí lúc di chuyển
        public class Status
        {
            public LoaiDiChuyen Type { get; set; }
            public int Vt1 { get; set; }
            public int Vt2 { get; set; }
        }
    }
}