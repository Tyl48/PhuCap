using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phu_cap
    {
        

        public string Ma_chuc_vu { get; set; }

        public string He_so_luong { get; set; }

        public string He_so_phu_cap { get; set; }
        
        public Phu_cap() { }
        public Phu_cap(string ma_chuc_vu, string he_so_luong, string he_so_phu_cap)
        {
           this.Ma_chuc_vu = ma_chuc_vu;
           this.He_so_luong = he_so_luong;
           this.He_so_phu_cap = he_so_phu_cap;
        }
    }
}
