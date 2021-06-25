using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication7.DAL
{
    public class KetNoi
    {
        public static SqlConnection connect()
        {

            String sql = @"Data Source=DESKTOP-T95I13N;Initial Catalog=bongDa;Integrated Security=True";

     //       String sql = @"Data Source=HOANGTIEN\SQLEXPRESS;Initial Catalog=Bong;Integrated Security=True";

            SqlConnection conn = new SqlConnection(sql);
            return conn;
        }
    }
}