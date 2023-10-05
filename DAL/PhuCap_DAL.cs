using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL
{
    public class PhuCap_DAL : Connect
    {
        public PhuCap_DAL() { }

        // Load
        public DataTable Load_PhuCap()
        {
            return Load_DL("select * from Phu_cap");
        }
        public void Insert_Phu_cap(Phu_cap ob)
        {
            string sql = "insert into Phu_cap values('" + ob.Ma_chuc_vu + "','"
                + ob.He_so_luong + "','" + ob.He_so_phu_cap + "')";
            Excecute(sql);
        }

        public void Update_Phu_cap(Phu_cap ob)
        {
            string sql = "update Phu_cap set He_so_luong ='" + ob.He_so_luong + "', He_so_phu_cap ='"+ob.He_so_phu_cap+"' " +
                "where Ma_chuc_vu ='" + ob.Ma_chuc_vu + "'";
            Excecute(sql);

        }
        public void Delete_Phu_cap(string Ma_chuc_vu)
        {
            string sql = "delete from Phu_cap where Ma_chuc_vu ='" + Ma_chuc_vu + "'";
            Excecute(sql);

        }
    }
}
