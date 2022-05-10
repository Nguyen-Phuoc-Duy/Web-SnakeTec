using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB
{
    public partial class userInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<TaiKhoan> danhsachtk = new List<TaiKhoan>();
            danhsachtk = (List<TaiKhoan>)Application["danhsach_tk"];
            foreach (TaiKhoan tk in danhsachtk)
            {
                if (tk.Email == (string)Session["email"])
                {
                    user_name.InnerText = tk.HoTen;
                    user_birthday.InnerText = tk.NgaySinh;
                    user_address.InnerText = tk.DiaChi;
                    user_sdt.InnerText = tk.SDT;
                    user_email.InnerText = tk.Email;
                }

            }
        }
    }
}