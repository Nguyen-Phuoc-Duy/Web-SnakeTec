using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_WEB
{
    public class TaiKhoan
    {
        string hoten;
        string ngaysinh;
        string diachi;
        string sdt;
        string email;
        string mk;


        public TaiKhoan()
        {
        }

        public TaiKhoan(string hoten, string ngaysinh, string diachi, string sdt, string email, string mk)
        {
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.DiaChi = diachi;
            this.SDT = sdt;
            this.Email = email;
            this.MK = mk;
        }

        public string HoTen
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public string NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public string MK
        {
            get { return mk; }
            set { mk = value; }
        }
    }
}