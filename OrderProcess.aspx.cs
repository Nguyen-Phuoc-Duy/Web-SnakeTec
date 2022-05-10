using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB
{
    public partial class OrderProcess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            string name = Request.QueryString["name"];
            string img = Request.QueryString["img"];
            string price = Request.QueryString["price"];
            price = price.Replace(".", "");
            int numprice = int.Parse(price);
            string user = (string)Session["email"];
            if(user == null)
            {
                Response.Redirect("dangnhap.aspx?id=" + id + "&name=" + name + "&img=" + img +"&price=" + price);
            }
            if (id == "" || name == "" || img == "" || price == "")
            {
                Response.Redirect("Home.aspx");
            }
            List<order> cartList = new List<order>();
            cartList = (List<order>)Application["order"];
            cartList.Add(new order(user, name, id, img, numprice));
            Response.Redirect("productDetail.aspx?id=" + id);
        }
    }
}