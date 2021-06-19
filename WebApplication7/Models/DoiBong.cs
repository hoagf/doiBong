using System;
using System.Collections.Generic;
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

        public DoiBong(string idClb, string tenClb, string quocGia, string loGo, int namThanhLap)
        {
            this.IdClb = idClb;
            this.TenClb = tenClb;
            this.QuocGia = quocGia;
            this.LoGo = loGo;
            this.NamThanhLap = namThanhLap;
        }

        public string IdClb { get => idClb; set => idClb = value; }
        public string TenClb { get => tenClb; set => tenClb = value; }
        public string QuocGia { get => quocGia; set => quocGia = value; }
        public string LoGo { get => loGo; set => loGo = value; }
        public int NamThanhLap { get => namThanhLap; set => namThanhLap = value; }
    }
}