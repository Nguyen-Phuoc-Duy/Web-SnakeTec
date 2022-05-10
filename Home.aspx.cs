using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
                        showLenovoList += " <span class='product-item-price-old'>" + String.Format("{0:0,0đ}", sp.GiaCu) + "</span>";
                        showLenovoList += " <span class='product-item-price-new'>" + String.Format("{0:0,0đ}", sp.GiaMoi) + "</span>";
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
                        showAcerList += " <span class='product-item-price-old'>" + String.Format("{0:0,0đ}", sp.GiaCu) + "</span>";
                        showAcerList += " <span class='product-item-price-new'>" + String.Format("{0:0,0đ}", sp.GiaMoi) + "</span>";
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
                        showAsusList += " <span class='product-item-price-old'>" + String.Format("{0:0,0đ}", sp.GiaCu) + "</span>";
                        showAsusList += " <span class='product-item-price-new'>" + String.Format("{0:0,0đ}", sp.GiaMoi) + "</span>";
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
}