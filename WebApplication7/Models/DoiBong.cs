using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class DoiBong
    {
       
        string idClb; 
        string tenClb;
        string quocGia;
        string loGo;
        int namThanhLap;

        public DoiBong()
        {
        }

        public DoiBong(string idClb, string tenClb, string quocGia, string loGo, int namThanhLap)
        {
            this.IdClb = idClb;
            this.TenClb = tenClb;
            this.QuocGia = quocGia;
            this.LoGo = loGo;
            this.NamThanhLap = namThanhLap;
        }
        [Display(Name = "Tên")]
        public string IdClb { get => idClb; set => idClb = value; }
        [Display(Name = "Tên Đầy đủ")]
        public string TenClb { get => tenClb; set => tenClb = value; }
        [Display(Name = "Quốc gia")]
        public string QuocGia { get => quocGia; set => quocGia = value; }
        [Display(Name = "Logo")]
        public string LoGo { get => loGo; set => loGo = value; }
        [Display(Name = "Năm thành lập")]
        public int NamThanhLap { get => namThanhLap; set => namThanhLap = value; }
    }
}