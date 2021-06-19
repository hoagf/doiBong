using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class CauThu
    {
        int idCauThu;
        string tenCauThu;
        string quocTich;
        string viTri;
        string gioiTinh;
        int luong;
        int namSinh;
        int chieuCao;
        int canNang;
        string idClb;
        string hinhAnh;

        public CauThu()
        {
        }

        public CauThu(int idCauThu, string tenCauThu, string quocTich, string viTri, string gioiTinh, int luong, int namSinh, int chieuCao, int canNang, string idClb, string hinhAnh)
        {
            this.IdCauThu = idCauThu;
            this.TenCauThu = tenCauThu;
            this.QuocTich = quocTich;
            this.ViTri = viTri;
            this.GioiTinh = gioiTinh;
            this.Luong = luong;
            this.NamSinh = namSinh;
            this.ChieuCao = chieuCao;
            this.CanNang = canNang;
            this.IdClb = idClb;
            this.HinhAnh = hinhAnh;
        }

        public int IdCauThu { get => idCauThu; set => idCauThu = value; }
        public string TenCauThu { get => tenCauThu; set => tenCauThu = value; }
        public string QuocTich { get => quocTich; set => quocTich = value; }
        public string ViTri { get => viTri; set => viTri = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int Luong { get => luong; set => luong = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public int ChieuCao { get => chieuCao; set => chieuCao = value; }
        public int CanNang { get => canNang; set => canNang = value; }
        public string IdClb { get => idClb; set => idClb = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
    }
}