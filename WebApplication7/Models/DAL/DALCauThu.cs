using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication7.Models;

namespace WebApplication7.DAL
{
    public class DALCauThu
    {
        //Cac ham:
        //getAllCauThu() = lay tat ca cau thu
        //SearchName() = tim kiem theo ten
        //getCauThuClb(string idClb) = Lay tat ca cau thu cua CLB
        //getMotCauThu(string id) = lay ra 1 cau thu theo id
        //addCauThu(CauThu ct) = Them moi 1 cau thu
        //editCauThu(CauThu ct) = Sua thong tin cau thu
        //deleteCauThu(string id) = Xoa 1 cau thu theo id

        SqlConnection conn = KetNoi.connect();
        public List<CauThu> getAllCauThu()
        {
            string sql = "SELECT * FROM cauThu";
            List<CauThu> list = new List<CauThu>();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
       
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new CauThu(reader.GetInt32(0), reader.GetString(1),
                    reader.GetString(2), reader.GetString(3), reader.GetString(4),
                    reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7),
                    reader.GetInt32(8), reader.GetString(9), reader.GetString(10))) ;
            }
            
            conn.Close();
            return list;
        }
        public List<CauThu> SearchName(string name)
        {
            string sql = "SELECT * FROM CauThu WHERE CauThu.tenCauthu LIKE N'%"+name+"%'";
            List<CauThu> list = new List<CauThu>();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new CauThu(reader.GetInt32(0), reader.GetString(1),
                    reader.GetString(2), reader.GetString(3), reader.GetString(4),
                    reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7),
                    reader.GetInt32(8), reader.GetString(9), reader.GetString(10)));
            }

            conn.Close();
            return list;
        }
        public List<CauThu> getCauThuClb(string idClb)
        {
            string sql = "SELECT * FROM cauThu WHERE cauThu.idClb = '"+idClb+"'";
            List<CauThu> list = new List<CauThu>();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new CauThu(reader.GetInt32(0), reader.GetString(1),
                    reader.GetString(2), reader.GetString(3), reader.GetString(4),
                    reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7),
                    reader.GetInt32(8), reader.GetString(9), reader.GetString(10)));
            }

            conn.Close();
            return list;
        }
        public CauThu getMotCauThu(string id)
        {
            string sql = "SELECT * FROM cauThu WHERE cauThu.idCauThu = '" + id + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                CauThu cbb = new CauThu(reader.GetInt32(0), reader.GetString(1),
                    reader.GetString(2), reader.GetString(3), reader.GetString(4),
                    reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7),
                    reader.GetInt32(8), reader.GetString(9), reader.GetString(10));
                return cbb;
            }
            else
            {
                return null;
            }
            conn.Close();
        }
        public Boolean addCauThu(CauThu ct)
        {
           //Id tu dong tang
            string sql = "INSERT INTO cauThu(tenCauthu, quocTich, viTri, gioiTinh, luong, namSinh, chieuCao, canNang, idClb, hinhAnh) VALUES (N'"+ct.TenCauThu+"', N'"+ct.QuocTich+"', N'"+ct.ViTri+"', N'"+ct.GioiTinh+"', "+ct.Luong+", '"+ct.NamSinh+"', "+ct.ChieuCao+", "+ct.CanNang+", '"+ct.IdClb+"', '"+ct.HinhAnh+"') ";
            SqlConnection conn = KetNoi.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery()>0;
            cmd.Dispose();


            //SqlCommand cmd = new SqlCommand("them", conn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@TenCt", SqlDbType.NVarChar).Value = ct.TenCauThu;
            //cmd.Parameters.AddWithValue("@QuocTich", SqlDbType.NVarChar).Value = ct.QuocTich;
            //cmd.Parameters.AddWithValue("@ViTri", SqlDbType.NVarChar).Value = ct.ViTri;
            //cmd.Parameters.AddWithValue("@GioiTinh", SqlDbType.NVarChar).Value = ct.GioiTinh;
            //cmd.Parameters.AddWithValue("@Luong", SqlDbType.Int).Value = ct.Luong;
            //cmd.Parameters.AddWithValue("@NamSinh", SqlDbType.Int).Value = ct.NamSinh;
            //cmd.Parameters.AddWithValue("@ChieuCao", SqlDbType.Int).Value = ct.ChieuCao;
            //cmd.Parameters.AddWithValue("@CanNang", SqlDbType.Int).Value = ct.CanNang;
            //cmd.Parameters.AddWithValue("@IDClb", SqlDbType.NVarChar).Value = ct.IdClb;
            //cmd.Parameters.AddWithValue("@HinhAnh", SqlDbType.NVarChar).Value = ct.HinhAnh;
            //cmd.ExecuteNonQuery();
            cmd.Dispose();


            conn.Close();
        }
        public void editCauThu(CauThu ct)
        {
            string sql = "UPDATE CauThu SET tenCauthu = N'"+ct.TenCauThu+"', quocTich = N'"+ct.QuocTich+"', viTri = N'"+ct.ViTri+"', gioiTinh = N'"+ct.GioiTinh+"',luong = "+ct.Luong+", namSinh="+ct.NamSinh+", chieuCao="+ct.ChieuCao+", canNang ="+ct.CanNang+", idClb = '"+ct.IdClb+"', hinhAnh = '"+ct.HinhAnh+"' WHERE idCauThu ="+ct.IdCauThu;
            SqlConnection conn = KetNoi.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

        }
        public void deleteCauThu(string id)
        {

            string sql = "DELETE CauThu WHERE idCauthu ='" + id + "'";
            SqlConnection conn = KetNoi.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
        
    }
}