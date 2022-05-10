using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB
{
    public partial class AcerPage : System.Web.UI.Page
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

            String showAcerList = "";
            string acer = "Acer";
            foreach (product sp in list)
            {
                string str2 = sp.TenSp;
                if (str2.StartsWith(acer) == true)
                {
                    showAcerList += "<div class=\"col m-5 t-3-3 c-2\"> ";
                    showAcerList += "<div class='product-item'>";
                    showAcerList += "<div class=\"product-item-info\">";
                    showAcerList += "<a href='productDetail.aspx?id=" + sp.ID + "' class=\"product-item-link\" runat='server'>";
                    showAcerList += "<div class='product-item-img' style='background-image: url(" + sp.ImgSp + ");'></div>";
                    showAcerList += " <div class='product-item-content'>";
                    showAcerList += "<h3 class='product-item-name'>" + sp.TenSp + "/" + sp.Ocung + "/" + sp.Ram + "/" + sp.CPU + "/" + sp.HeDieuHanh + "</h3>";
                    showAcerList += " <div class='product-item-price'>";
                    showAcerList += " <span class='product-item-price-old'>" + sp.GiaCu + "</span>";
                    showAcerList += " <span class='product-item-price-new'>" + sp.GiaMoi + "</span>";
                    showAcerList += "</div>";
                    showAcerList += " </div>";
                    showAcerList += " </a> ";
                    showAcerList += "</div>";
                    showAcerList += "<div class='product-item-bot'>";
                    showAcerList += "<div class='product-item-stock'>";
                    showAcerList += " <i class='fas fa-check'></i>";
                    showAcerList += " <span>Còn hàng</span>";
                    showAcerList += "</div>";
                    showAcerList += "<button class='product-item-addcart' onclick='processorder()'>";
                    showAcerList += "<i class='fas fa-cart-plus'></i>";
                    showAcerList += "<span>Đặt hàng</span>";
                    showAcerList += "</button>";
                    showAcerList += "</div>";
                    showAcerList += "</div>";
                    showAcerList += "</div>";

                }
            }
            AcerList.InnerHtml = showAcerList;
        }
    }
}