using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class PhuCap_BUS
    {
        PhuCap_DAL PC = new PhuCap_DAL();
        public DataTable Load_Bus()
        {
            return PC.Load_PhuCap();
        }
        public void Insert_Bus(Phu_cap ob)
        {
            PC.Insert_Phu_cap(ob);
        }
        public void Update_Bus(Phu_cap ob)
        {
            PC.Update_Phu_cap(ob);
        }
        public void Delete_Bus(string Ma_chuc_vu)
        {
            PC.Delete_Phu_cap(Ma_chuc_vu);
        }

    }
}
