using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class dbConnectionData
    {
        public static SqlConnection HamKetNoi()
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-755C2GPC;Initial Catalog=TrungTamTinHoc;Integrated Security=True");
            return Conn;
        }
    }
}
