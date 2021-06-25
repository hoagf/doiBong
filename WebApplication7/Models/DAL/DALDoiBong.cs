using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication7.Models;

namespace WebApplication7.DAL
{
    public class DADoiBong
    {
        //Cac ham:
        //getAllDoiBong() = lay tat ca doi bong
        //SearchName() = tim kiem theo ten
        //getMotDoiBong(string id) = lay ra 1 clb theo id
        //addClb(DoiBong ct) = Them moi 1 doiBong
        //editDoiBong(Doibong ct) = Sua thong tin doiBong
        //deleteDoibong(string id) = Xoa 1 doiBong theo id
        SqlConnection conn = KetNoi.connect();
        public List<DoiBong> getVidu(string id)
        {
            string sql = "SELECT * FROM DoiBong WHERE DoiBong.namThanhLap =" + id + "";
            List<DoiBong> list = new List<DoiBong>();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new DoiBong(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4)));

            }

            conn.Close();
            return list;
        }
        public List<DoiBong> getAllDoiBong()
        {
            string sql = "SELECT * FROM DoiBong";
            List<DoiBong> list = new List<DoiBong>();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new DoiBong(reader.GetString(0), reader.GetString(1),reader.GetString(2),reader.GetString(3), reader.GetInt32(4)));
            }

            conn.Close();
            return list;
        }
        public List<DoiBong> searchName(String name)
        {
            string sql = "SELECT * FROM DoiBong WHERE DoiBong.tenClb LIKE N'%"+name+"%'";
            List<DoiBong> list = new List<DoiBong>();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new DoiBong(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4)));
            }

            conn.Close();
            return list;
        }

        public DoiBong getMotDoiBong(string id)
        {
            string sql = "SELECT * FROM DoiBong WHERE DoiBong.idClb = '" + id + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                DoiBong db = new DoiBong(reader.GetString(0), reader.GetString(1), 
                    reader.GetString(2), reader.GetString(3), reader.GetInt32(4));
                return db;
            }
            else
            {
                return null;
            }
            conn.Close();
        }
        public void addDoiBong(DoiBong db)
        {
           // Id tu dong tang
            string sql = "INSERT INTO DoiBong(idClb, tenClb, quocGia, loGo, namThanhLap) " +
                "VALUES ('" + db.IdClb + "', '" + db.TenClb + "', '"+db.QuocGia+ "','"+db.LoGo+ "','"+db.NamThanhLap+ "')" ;
            SqlConnection conn = KetNoi.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
        public void editDoiBong(DoiBong db)
        {
            string sql = "UPDATE DoiBong SET tenClb = '"+db.TenClb+
                "', quocGia = '"+db.QuocGia+"', loGo ='"+db.LoGo+"',namThanhLap = "+
                db.NamThanhLap+"WHERE DoiBong.idClb ='"+db.IdClb+"'";

            SqlConnection conn = KetNoi.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

            }
        public void deleteDoiBong(string id)
        {

            string sql = "DELETE DoiBong WHERE idClb ='" + id + "'";
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