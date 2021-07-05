using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

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
        [Required(ErrorMessage = "Vui lòng nhập")]
        [Display(Name = "ID")]
        public int IdHlv { get => idHlv; set => idHlv = value; }
        [Required(ErrorMessage = "Vui lòng nhập")]
        [Display(Name = "Tên Huấn Luyện Viên")]
        public string TenHlv { get => tenHlv; set => tenHlv = value; }
        [Required(ErrorMessage = "Vui lòng nhập")]
        [Display(Name = "Quốc Tịch")]
        public string QuocTich { get => quocTich; set => quocTich = value; }
        [Required(ErrorMessage = "Vui lòng nhập")]
        [Display(Name = "Năm Sinh")]
        public int NamSinh { get => namSinh; set => namSinh = value; }
        [Required(ErrorMessage = "Vui lòng nhập")]
        [Display(Name = "Giới Tính")]
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        [Required(ErrorMessage = "Vui lòng nhập")]
        [Display(Name = "Chức Vụ")]
        public string ChucVu { get => chucVu; set => chucVu = value; }
        [Required(ErrorMessage = "Vui lòng nhập")]
        [Display(Name = "ID CLB")]
        public string IdClb { get => idClb; set => idClb = value; }
        [Required(ErrorMessage = "Vui lòng nhập")]
        [Display(Name = "Link Ảnh")]
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
    }
}