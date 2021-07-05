using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage = "Vui lòng nhập")]
        [Display(Name = "Họ tên")]
        public string TenCauThu { get => tenCauThu; set => tenCauThu = value; }
        [Required(ErrorMessage = "Vui lòng nhập")]
        [Display(Name = "Quốc tịch")]
        public string QuocTich { get => quocTich; set => quocTich = value; }
        [Required(ErrorMessage = "Vui lòng nhập")]
        [Display(Name = "Vị trí")]
        public string ViTri { get => viTri; set => viTri = value; }
        [Required(ErrorMessage = "Vui lòng nhập")]
        [Display(Name = "Giới tính")]
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        [Required(ErrorMessage = "Vui lòng nhập")]
        [Display(Name = "Lương")]
        public int Luong { get => luong; set => luong = value; }
        [Required(ErrorMessage = "Vui lòng nhập")]
        [Display(Name = "Năm sinh")]
        public int NamSinh { get => namSinh; set => namSinh = value; }
        [Required(ErrorMessage = "Vui lòng nhập")]
        [Display(Name = "Chiều cao")]
        public int ChieuCao { get => chieuCao; set => chieuCao = value; }
        [Required(ErrorMessage = "Vui lòng nhập")]
        [Display(Name = "Cân nặng")]
        public int CanNang { get => canNang; set => canNang = value; }
        [Required(ErrorMessage = "Vui lòng nhập")]
        [Display(Name = "ID CLB")]
        public string IdClb { get => idClb; set => idClb = value; }
        [Required(ErrorMessage = "Vui lòng nhập")]
        [Display(Name = "Link Ảnh")]
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
    }
}