using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB
{
    public partial class ChiTietSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //bool check = false;
            string request = Request.QueryString["id"];
            List<product> listsp = new List<product>();
            listsp = (List<product>)Application["sanpham"];
            List<order> cartList = new List<order>();
            cartList = (List<order>)Application["order"];

            foreach (product sp in listsp)
            {
                if (sp.ID == request)
                {
                    product_img.InnerHtml = "<img src = '" + sp.ImgSp + "' id='product-info-img' class='product-info-img' width='100%' alt='" + sp.ID + "' >";
                    product_label.InnerText = sp.TenSp + " / " + sp.Ram + " / " + sp.Ocung + " / " + sp.CPU + " / " + sp.HeDieuHanh;
                    product_name.InnerText = sp.TenSp;
                    product_ram.InnerText = sp.Ram;
                    product_cpu.InnerText = sp.CPU;
                    product_hdd.InnerText = sp.Ocung;
                    //String op = String.Format("{0:0,0}", sp.GiaCu);
                    //String np = String.Format("{0:0,0}", sp.GiaMoi)
                    old_price.InnerText = String.Format("{0:0,0đ}", sp.GiaCu); ;
                    new_price.InnerText = String.Format("{0:0,0đ}", sp.GiaMoi);
                }
            }
        }
    }
}