using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB
{
    public partial class LenovoPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["dangxuat"] == "Đăng xuất")
            {
                Session.Remove("name");
                Session.Abandon();
                Response.Redirect("Home.aspx");
            }

            List<product> list = new List<product>();
            list = (List<product>)Application["sanpham"];
            String showLenovoList = "";
            string lenovo = "Lenovo";
            foreach (product sp in list)
            {
                string str2 = sp.TenSp;
                if (str2.StartsWith(lenovo) == true)
                {
                    showLenovoList += "<div class=\"col m-5 t-3-3 c-2\"> ";
                    showLenovoList += "<div class=\"product-item\">";
                    showLenovoList += "<div class=\"product-item-info\">";
                    showLenovoList += "<a href='productDetail.aspx?id=" + sp.ID + "' class=\"product-item-link\" runat=\"server\">";
                    showLenovoList += "<div class='product-item-img' style='background-image: url(" + sp.ImgSp + ");'></div>";
                    showLenovoList += " <div class='product-item-content'>";
                    showLenovoList += "<h3 class='product-item-name'>" + sp.TenSp + "/" + sp.Ocung + "/" + sp.Ram + "/" + sp.CPU + "/" + sp.HeDieuHanh + "</h3>";
                    showLenovoList += " <div class='product-item-price'>";
                    showLenovoList += " <span class='product-item-price-old'>" + sp.GiaCu + "</span>";
                    showLenovoList += " <span class='product-item-price-new'>" + sp.GiaMoi + "</span>";
                    showLenovoList += "</div>";
                    showLenovoList += " </div>";
                    showLenovoList += " </a> ";
                    showLenovoList += "</div>";
                    showLenovoList += "<div class='product-item-bot'>";
                    showLenovoList += "<div class='product-item-stock'>";
                    showLenovoList += " <i class='fas fa-check'></i>";
                    showLenovoList += " <span>Còn hàng</span>";
                    showLenovoList += "</div>";
                    showLenovoList += "<button class='product-item-addcart' onclick='processorder()'>";
                    showLenovoList += "<i class='fas fa-cart-plus'></i>";
                    showLenovoList += "<span>Đặt hàng</span>";
                    showLenovoList += "</button>";
                    showLenovoList += "</div>";
                    showLenovoList += "</div>";
                    showLenovoList += "</div>";

                }
            }
            LenovoList.InnerHtml = showLenovoList;
        }
    }
}