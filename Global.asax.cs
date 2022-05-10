using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;


namespace BTL_WEB
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["danhsach_tk"] = new List<TaiKhoan>();
            List<TaiKhoan> tk = (List<TaiKhoan>)Application["danhsach_tk"];
            tk.Add(new TaiKhoan("Dinh", "2001-08-29","Hà Nội","0192746356","dinh@gmail.com","nhodinh1"));
            Application["danhsach_tk"] = tk;


            Application["sanpham"] = new List<product>();
            List<product> listsp = (List<product>)Application["sanpham"];

            listsp.Add(new product("Acer Aspire 3", "i5-1035G1", "8 GB", "512GB", "Win 11", "16.990.000", "14.679.000", "image/laptops/acer/AcerAspire3.jpg", "1"));
            listsp.Add(new product("Acer Aspire 5", "i5-1135G7", "8 GB", "512GB SSD", "Win 11", "18.990.000", "15.490.000", "image/laptops/acer/AcerAspire5.png", "2"));
            listsp.Add(new product("Acer Swift 3x", "R5-5500U", "16 GB", "512GB SSD", "Win 11", "21.499.000", "18.579.000", "image/laptops/acer/AcerSwift3x.jpg", "3"));
            listsp.Add(new product("Acer Nitro 5 Gaming", "i5-11400H", "8 GB", "512GB SSD", "Win 11", "26.390.000", "32.990.000", "image/laptops/acer/acerNitro5.jpg", "4"));
            listsp.Add(new product("Acer Predator Tritor 300", "i7-11800H", "16 GB", "512GB SSD", "Win 11", "50.990.000","40.890.000" , "image/laptops/acer/acerPredatorTriton300.jpg", "5"));
            listsp.Add(new product("Acer TravelMate", "i5-1135G7", "8 GB", "512GB SSD", "Win 11", "23.290.000", "22.290.000", "image/laptops/acer/acerTravelmate.jpg", "6"));
            listsp.Add(new product("Acer Aspire 7", "i5-10300H", "8 GB", "512GB SSD", "Win 11", "21.990.000", "19.790.000", "image/laptops/acer/acerAspire7.jpg", "7"));
            listsp.Add(new product("Acer Aspire 3", "i5-1035G1", "8 GB", "512GB", "Win 11", "16.990.000", "14.679.000", "image/laptops/acer/AcerAspire3.jpg", "8"));
            listsp.Add(new product("Acer Aspire 5", "i5-1135G7", "8 GB", "512GB SSD", "Win 11", "18.990.000", "15.490.000", "image/laptops/acer/AcerAspire5.png", "9"));
            listsp.Add(new product("Acer Swift 3x", "R5-5500U", "16 GB", "512GB SSD", "Win 11", "21.499.000", "18.579.000", "image/laptops/acer/AcerSwift3x.jpg", "10"));
            listsp.Add(new product("Acer Nitro 5 Gaming", "i5-11400H", "8 GB", "512GB SSD", "Win 11", "26.390.000", "32.990.000", "image/laptops/acer/acerNitro5.jpg", "11"));
            listsp.Add(new product("Acer Predator Tritor 300", "i7-11800H", "16 GB", "512GB SSD", "Win 11", "50.990.000", "49.089.000", "image/laptops/acer/acerPredatorTriton300.jpg", "12"));
            listsp.Add(new product("Acer TravelMate", "i5-1135G7", "8 GB", "512GB SSD", "Win 11", "23.290.000", "22.290.000", "image/laptops/acer/acerTravelmate.jpg", "13"));
            listsp.Add(new product("Acer Aspire 7", "i5-10300H", "8 GB", "512GB SSD", "Win 11", "21.990.000", "19.790.000", "image/laptops/acer/acerAspire7.jpg", "14"));

            listsp.Add(new product("Asus TUF Gaming", "i5-10300H", "8 GB", "512GB SSD", "Win 11", "27.990.000", "25.990.000", "image/laptops/asus/asusTuf.jpg", "15"));
            listsp.Add(new product("Asus Vivobook A414", "i3-1125G4", "8 GB", "512GB SSD", "Win 10", "14.490.000", "13.390.000", "image/laptops/asus/asusVivobook.jpg", "16"));
            listsp.Add(new product("Asus ZenBook", "i5-1135G7", "8 GB", "512GB SSD", "Win 10", "32.990.000", "30.990.000", "image/laptops/asus/asusZenbook.jpg", "17"));
            listsp.Add(new product("Asus ExpertBook", "i5-1135G7", "8 GB", "512GB SSD", "Win 10", "30.490.000", "29.490.000", "image/laptops/asus/asusExpertbook.jpg", "18"));
            listsp.Add(new product("Asus TUF Gaming", "i5-10300H", "8 GB", "512GB SSD", "Win 11", "27.990.000", "25.990.000", "image/laptops/asus/asusTuf.jpg", "19"));
            listsp.Add(new product("Asus Vivobook A414", "i3-1125G4", "8 GB", "512GB SSD", "Win 10", "14.490.000", "13.390.000", "image/laptops/asus/asusVivobook.jpg", "20"));
            listsp.Add(new product("Asus ZenBook", "i5-1135G7", "8 GB", "512GB SSD", "Win 10", "32.990.000", "30990000", "image/laptops/asus/asusZenbook.jpg", "21"));
            listsp.Add(new product("Asus ExpertBook", "i5-1135G7", "8 GB", "512GB SSD", "Win 10", "30.490.000", "29.490.000", "image/laptops/asus/asusExpertbook.jpg", "22"));
            listsp.Add(new product("Asus ExpertBook", "i5-1135G7", "8 GB", "512GB SSD", "Win 10", "30.490.000", "29.490.000", "image/laptops/asus/asusExpertbook.jpg", "23"));
            listsp.Add(new product("Asus TUF Gaming", "i5-10300H", "8 GB", "512GB SSD", "Win 11", "27.990.000", "25.990.000", "image/laptops/asus/asusTuf.jpg", "24"));

            listsp.Add(new product("Lenovo Ideapad 3", "i5-1135G7", "8 GB", "512GB SSD", "Win 10", "18.700.000", "16.490.000", "image/laptops/lenovo/lenovoIdeapad3.jpg", "25"));
            listsp.Add(new product("Lenovo Ideapad 5", "i5-1135G7", "8 GB", "512GB SSD", "Win 10", "19.700.000", "18.490.000", "image/laptops/lenovo/lenovoIdeapad5.jpg", "26"));
            listsp.Add(new product("Lenovo Yoga Slim", "i7-11655", "16 GB", "512GB SSD", "Win 10", "34.000.000", "32.000.000", "image/laptops/lenovo/lenovoYoga.jpg", "27"));
            listsp.Add(new product("Lenovo Thinkbook", "Ryzen 5", "16 GB", "512GB SSD", "Win 10", "25.880.000", "23.990.000", "image/laptops/lenovo/lenovoThinkbook.jpg", "28"));
            listsp.Add(new product("Lenovo Yoga Slim", "i7-11655", "16 GB", "512GB SSD", "Win 10", "34.000.000", "32.000.000", "image/laptops/lenovo/lenovoYoga.jpg", "29"));
            listsp.Add(new product("Lenovo Thinkbook", "Ryzen 5", "16 GB", "512GB SSD", "Win 10", "25.880.000", "23.990.000", "image/laptops/lenovo/lenovoThinkbook.jpg", "30"));
            listsp.Add(new product("Lenovo Ideapad 3", "i5-1135G7", "8 GB", "512GB SSD", "Win 10", "18.700.000", "16.490.000", "image/laptops/lenovo/lenovoIdeapad3.jpg", "31"));
            listsp.Add(new product("Lenovo Ideapad 5", "i5-1135G7", "8 GB", "512GB SSD", "Win 10", "19.700.000", "18.490.000", "image/laptops/lenovo/lenovoIdeapad5.jpg", "32"));
            listsp.Add(new product("Lenovo Yoga Slim", "i7-11655", "16 GB", "512GB SSD", "Win 10", "34.000.000", "32.000.000", "image/laptops/lenovo/lenovoYoga.jpg", "33"));
            listsp.Add(new product("Lenovo Thinkbook", "Ryzen 5", "16 GB", "512GB SSD", "Win 10", "25.880.000", "23.990.000", "image/laptops/lenovo/lenovoThinkbook.jpg", "34"));
            listsp.Add(new product("Lenovo Yoga Slim", "i7-11655", "16 GB", "512GB SSD", "Win 10", "34.000.000", "32.000.000", "image/laptops/lenovo/lenovoYoga.jpg", "35"));
            listsp.Add(new product("Lenovo Thinkbook", "Ryzen 5", "16 GB", "512GB SSD", "Win 10", "25.880.000", "23.990.000", "image/laptops/lenovo/lenovoThinkbook.jpg", "36"));



            Application["sanpham"] = listsp;

            //cart
            Application["order"] = new List<order>();
            List<order> cartlist = (List<order>)Application["order"];
            Application["order"] = cartlist;

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["loginCount"] = 0;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}