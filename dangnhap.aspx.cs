using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB
{
    public partial class dangnhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (IsPostBack)
            //{
            //    string email = Request.Form["email"];
            //    string mk = Request.Form["mk"];

            //    List<TaiKhoan> danhsach;
            //    danhsach = (List<TaiKhoan>)Application["danhsach_tk"];

            //    foreach (TaiKhoan tk in danhsach)
            //    {
            //        if (email == tk.Email && mk == tk.MK)
            //        {
            //            Session["name"] = email;
            //            Response.Redirect("home.aspx");
            //        }

            //    }
            //}
            if (IsPostBack)
            {
                string email = Request.Form["email"];
                string mk = Request.Form["mk"];

                List<TaiKhoan> danhsach = (List<TaiKhoan>)Application["danhsach_tk"];       

                foreach (TaiKhoan tk in danhsach)
                {
                    if (email == tk.Email && mk == tk.MK)
                    {
                        Session["name"] = tk.HoTen;
                        Session["email"] = email;
                        Response.Redirect("Home.aspx");
                    }

                }
                login_err.InnerText = "Sai thông tin tài khoản";
                int loginCount = (int)Session["loginCount"];
                loginCount++;

                Session["loginCount"] = loginCount;
                if (loginCount > 2)
                {

                    loginErr3.InnerText = "Bạn đã nhập sai quá 3 lần";
                }

            }


        }
    }
}