using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB
{
    public partial class themSp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                bool check = false;
                string idSp = Request.Form["idSp"];
                string tenSp = Request.Form["tenSp"];
                string cpu = Request.Form["cpu"];
                string ram = Request.Form["ram"];
                string hd = Request.Form["hd"];
                string hdh = Request.Form["hdh"];
                //string price = Request.Form["gia"];
                string giaCu = Request.Form["gia"];
                //int giaCu = int.Parse(price);
                string discount = Request.Form["discount"];
                int giamGia = int.Parse(discount);
                string img = Request.Form["anh"]; ;
                List<product> listSp = new List<product>();
                listSp = (List<product>)Application["sanpham"];

                foreach (product sp in listSp)
                {
                    if (sp.ID == idSp)
                    {
                        errId.InnerText = "Mã sản phẩm đã tồn tại";
                        check = true;
                    }
                    if (sp.TenSp == tenSp)
                    {
                        errName.InnerText = "Tên sản phẩm đã tồn tại";
                        check = true;
                    }

                }
                if (check == false)
                {
                    errId.InnerText = errName.InnerText = "";
                    int c, d;
                    c = int.Parse(giaCu);
                    d = c - c * giamGia / 100;
                    string a, b;
                    a = Convert.ToString(c);
                    b = Convert.ToString(d);
                    listSp.Add(new product(tenSp, cpu, ram, hd, hdh, a, b, img, idSp));
                    Application["sanpham"] = listSp;
                    notify.InnerText = "Thêm sản phẩm thành công !";

                }
            }
        }
    }
}