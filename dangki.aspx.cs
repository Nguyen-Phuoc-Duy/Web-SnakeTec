using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB
{
    public partial class dangki : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["name"]==null)
            //{
            //    Response.Redirect("dangnhap.aspx");
            //}    
            //else
            //{
            //    Response.Write("Xin chao: "+Session["name"]);
            //}

            if (IsPostBack)
            {
                bool check = false;
                string email = Request.Form["email"];
                string hoten = Request.Form["hoten"];
                string mk = Request.Form["mk"];
                string diachi = Request.Form["diachi"];
                string ngaysinh = Request.Form["ngaysinh"];
                string sdt = Request.Form["sdt"];

                List<TaiKhoan> danhsach = new List<TaiKhoan>();
                danhsach = (List<TaiKhoan>)Application["danhsach_tk"];

                foreach (TaiKhoan tk in danhsach)
                {
                    if (tk.Email == email)
                    {
                        regis_err.InnerText = "Tài khoản đã tồn tại";
                        check = true;
                    }

                }
                if (check == false)
                {

                    danhsach.Add(new TaiKhoan(hoten, ngaysinh, diachi, sdt, email, mk));
                    Application["danhsach_tk"] = danhsach;
                    Response.Redirect("Dangnhap.aspx");

                }
            }

        }
    }
}