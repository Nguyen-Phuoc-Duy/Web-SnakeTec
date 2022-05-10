using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB
{
    public partial class AsusPage : System.Web.UI.Page
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

            String showAsusList = "";
            string asus = "Asus";
            foreach (product sp in list)
            {
                string str2 = sp.TenSp;
                if (str2.StartsWith(asus) == true)
                {
                    showAsusList += "<div class=\"col m-5 t-3-3 c-2\"> ";
                    showAsusList += "<div class='product-item'>";
                    showAsusList += "<div class=\"product-item-info\">";
                    showAsusList += "<a href='productDetail.aspx?id=" + sp.ID + "' class=\"product-item-link\" runat='server'>";
                    showAsusList += "<div class='product-item-img' style='background-image: url(" + sp.ImgSp + ");'></div>";
                    showAsusList += " <div class='product-item-content'>";
                    showAsusList += "<h3 class='product-item-name'>" + sp.TenSp + "/" + sp.Ocung + "/" + sp.Ram + "/" + sp.CPU + "/" + sp.HeDieuHanh + "</h3>";
                    showAsusList += " <div class='product-item-price'>";
                    showAsusList += " <span class='product-item-price-old'>" + sp.GiaCu + "</span>";
                    showAsusList += " <span class='product-item-price-new'>" + sp.GiaMoi + "</span>";
                    showAsusList += "</div>";
                    showAsusList += " </div>";
                    showAsusList += " </a> ";
                    showAsusList += "</div>";
                    showAsusList += "<div class='product-item-bot'>";
                    showAsusList += "<div class='product-item-stock'>";
                    showAsusList += " <i class='fas fa-check'></i>";
                    showAsusList += " <span>Còn hàng</span>";
                    showAsusList += "</div>";
                    showAsusList += "<button class='product-item-addcart' onclick='processorder()'>";
                    showAsusList += "<i class='fas fa-cart-plus'></i>";
                    showAsusList += "<span>Đặt hàng</span>";
                    showAsusList += "</button>";
                    showAsusList += "</div>";
                    showAsusList += "</div>";
                    showAsusList += "</div>";

                }
            }
            AsusList.InnerHtml = showAsusList;
        }
    }
}