using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class D_GiaoVien_PDT
    {
        public static DataTable showGV()
        {
            SqlConnection conn = dbConnectionData.HamKetNoi();
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("sp_ViewAll_GiaoVien", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return (dt);
        }
    }
}
