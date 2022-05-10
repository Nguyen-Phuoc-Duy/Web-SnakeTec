using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB
{
    public partial class cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("dangnhap.aspx");
            }
            bool check = true;
            List<order> cartList = new List<order>();
            cartList = (List<order>)Application["order"];    
            string CartList = "";
            int sum = 0;
            foreach (order sp in cartList)
            {
                if (Request.Form["xoa"] == sp.ProductID1)
                {
                    cartList.Remove(sp);
                    break;
                }
            }
            foreach (order od in cartList)
            {
                if (od.UserID == (string)Session["email"]) { 
                    CartList += "<tr>";
                    CartList += "<td class='image'>";
                    CartList += "<div class='product-img'>";
                    CartList += "<a href = ''><img src = "+od.ImgSp+" alt = '' ></a> ";
                    CartList += "</div>";
                    CartList += "</td>";
                    CartList += "<td class='item'>";
                    CartList += " <a href = ''><strong>"+od.NameID1+"</strong></ a > ";
                    CartList += "</td>";
                    CartList += "<td class='qty'>1</ td > ";
                    CartList += "<td class='price'>"+od.Gia+"</td>";
                    CartList += "<td class='remove'><button type='submit' class='btn' name='xoa' value='" + od.ProductID1 + "'>Xóa</button></td>";
                    CartList += "</tr>";
                    sum += od.Gia;
                    check = false;
                }
                
            }
            cart_list.InnerHtml = CartList;
            cart_total_price.InnerText = string.Format("{0:0,0đ}", sum);       
            if(check == true)
            {
                cart_list.InnerHtml = "<tr><td colspan='5'><span>không có sản phẩm nào trong giỏ hàng </span></td></tr>";
            }
            
        }
    }
}