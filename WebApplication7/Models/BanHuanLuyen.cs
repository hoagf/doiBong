using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class BanHuanLuyen
    {
        int idHlv;
        string tenHlv;
        string quocTich;
        int namSinh;
        string gioiTinh;
        string chucVu;
        string idClb;
        string hinhAnh;

        public BanHuanLuyen() { }
        public BanHuanLuyen(int idHlv, string tenHlv, string quocTich, int namSinh, string gioiTinh, string chucVu, string idClb, string hinhAnh)
        {
            this.IdHlv = idHlv;
            this.TenHlv = tenHlv;
            this.QuocTich = quocTich;
            this.NamSinh = namSinh;
            this.GioiTinh = gioiTinh;
            this.ChucVu = chucVu;
            this.IdClb = idClb;
            this.HinhAnh = hinhAnh;
        }

        public int IdHlv { get => idHlv; set => idHlv = value; }
        public string TenHlv { get => tenHlv; set => tenHlv = value; }
        public string QuocTich { get => quocTich; set => quocTich = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string IdClb { get => idClb; set => idClb = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
    }
}