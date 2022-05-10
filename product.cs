using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_WEB
{
    public class product
{
        string tensanpham, cpu, ram, ocung, hedieuhanh, imgSp, id;
        string giaCu, giaMoi;
   

        public product(string tensanpham, string cpu, string ram, string ocung, string hedieuhanh, string giaCu, string giaMoi, string imgSp, string id)
        {
            this.TenSp = tensanpham;
            this.CPU = cpu;
            this.Ram = ram;
            this.Ocung = ocung;
            this.HeDieuHanh = hedieuhanh;
            this.ImgSp = imgSp;
            this.GiaCu = giaCu;
            this.GiaMoi = giaMoi;
            this.ID = id;
        }

        public string TenSp
        {
            get { return tensanpham; }
            set { tensanpham = value; }
        }
        public string Ram
        {
            get { return ram; }
            set { ram = value; }
        }
        public string Ocung
        {
            get { return ocung; }
            set { ocung = value; }
        }
        public string HeDieuHanh
        {
            get { return hedieuhanh; }
            set { hedieuhanh = value; }
        }
        public string CPU
        {
            get
            {
                return cpu;
            }
            set { cpu = value; }
        }
        public string GiaCu
        {
            get { return giaCu; }
            set { giaCu = value; }
        }
        public string GiaMoi
        {
            get { return giaMoi; }
            set { giaMoi = value; }
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string ImgSp
        {
            get { return imgSp; }
            set { imgSp = value; }
        }
    }

}