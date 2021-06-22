using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication7.Models;

namespace WebApplication7.DAL
{
    public class DALBanHuanLuyen
    {
        //Cac ham:
        //getAllBHL() = lay tat ca HLV
        //SearchName() = tim kiem theo ten
        //getBHLCuaCLB(string id) = Lay tat ca HLV cua CLB
        //getMotBHL(string id) = lay ra 1 HLV theo id
        //addBHL(BanHuanLuyen bhl) = Them moi 1 HLV
        //editBHL(BanHuanLuyen bhl) = Sua thong tin HLV
        //deleteBHL(string id) = Xoa 1 HLV theo id
        SqlConnection conn = KetNoi.connect();
        public List<BanHuanLuyen> getAllBHL()
        {
            string sql = "SELECT * FROM BanHuanLuyen";
            List<BanHuanLuyen> list = new List<BanHuanLuyen>();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new BanHuanLuyen(reader.GetInt32(0), reader.GetString(1),
                    reader.GetString(2), reader.GetInt32(3), reader.GetString(4),
                        reader.GetString(5), reader.GetString(6), reader.GetString(7)));
            }

            conn.Close();
            return list;
        }
        public List<BanHuanLuyen> SearchName(string name)
        {
            string sql = "SELECT * FROM BanHuanLuyen WHERE BanHuanLuyen.tenHlv LIKE N'%"+name+"%'";
            List<BanHuanLuyen> list = new List<BanHuanLuyen>();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new BanHuanLuyen(reader.GetInt32(0), reader.GetString(1),
                    reader.GetString(2), reader.GetInt32(3), reader.GetString(4),
                        reader.GetString(5), reader.GetString(6), reader.GetString(7)));
            }

            conn.Close();
            return list;
        }
        public List<BanHuanLuyen> getBHLCuaCLB(string id)
        {
            string sql = "SELECT * FROM BanHuanLuyen WHERE BanHuanLuyen.idClb ='"+id+"'";
            List<BanHuanLuyen> list = new List<BanHuanLuyen>();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new BanHuanLuyen(reader.GetInt32(0), reader.GetString(1),
                    reader.GetString(2), reader.GetInt32(3), reader.GetString(4),
                        reader.GetString(5), reader.GetString(6), reader.GetString(7)));
            }

            conn.Close();
            return list;
        }
        public BanHuanLuyen getMotBHL(string id)
        {
            string sql = "select * from BanHuanLuyen where BanHuanLuyen.idHlv = '" + id + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                BanHuanLuyen bhl = new BanHuanLuyen(reader.GetInt32(0), reader.GetString(1),
                    reader.GetString(2), reader.GetInt32(3), reader.GetString(4),
                        reader.GetString(5), reader.GetString(6), reader.GetString(7));
                return bhl;
            }
            else
            {
                return null;
            }
            conn.Close();
        }
        public void addBHL(BanHuanLuyen bhl)
        {
            //Id tu dong tang
            string sql = "INSERT INTO BanHuanLuyen(tenHlv, quocTich, namSinh, gioiTinh, chucVu, idClb, hinhAnh) " +
                "VALUES ('" + bhl.TenHlv + "', '" + bhl.QuocTich + "', " +bhl.NamSinh+ ", '" + bhl.GioiTinh + 
                "','"+bhl.ChucVu+ "','" + bhl.IdClb + "', '" + bhl.HinhAnh + "') ";
            SqlConnection conn = KetNoi.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
        public void editBHL(BanHuanLuyen bhl)
        {
            string sql = "UPDATE BanHuanLuyen SET tenHlv = '" + bhl.TenHlv + "', quocTich = '" + bhl.QuocTich + 
                "', namSinh = " + bhl.NamSinh + ", gioiTinh ='" + bhl.GioiTinh + "',chucVu = '" + bhl.ChucVu + 
                "', idClb ='"+bhl.IdClb+"', hinhAnh = '" +bhl.HinhAnh+ "' WHERE idHlv =" + bhl.IdHlv;

            SqlConnection conn = KetNoi.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

        }
        public void deleteBHL(string id)
        {

            string sql = "DELETE BanHuanLuyen WHERE idHlv ='" + id + "'";
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