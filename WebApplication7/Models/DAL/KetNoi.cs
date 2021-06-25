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
<<<<<<< HEAD
            String sql = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=bongDa;Integrated Security=True";
=======
            String sql = @"Data Source=HOANGTIEN\SQLEXPRESS;Initial Catalog=Bong;Integrated Security=True";
>>>>>>> c65e22bba26b031f0ab7370d5e4cc2701742f32d
            SqlConnection conn = new SqlConnection(sql);
            return conn;
        }
    }
}