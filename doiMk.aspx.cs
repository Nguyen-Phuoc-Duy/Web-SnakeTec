using BTL_WEB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebST
{
    public partial class doiMk : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<TaiKhoan> danhsachtk = new List<TaiKhoan>();
            danhsachtk = (List<TaiKhoan>)Application["danhsach_tk"];
            foreach (TaiKhoan tk in danhsachtk)
            {
                if (tk.Email == (string)Session["email"])
                {
                    //if (Request.QueryString["email"] != ""
                    //)
                {
                    hoten.Value = tk.HoTen;
                    ngaysinh.Value = tk.NgaySinh;
                    sdt.Value = tk.SDT;
                    email.Value = tk.Email;
                    diachi.Value = tk.DiaChi;
                    matkhau1.Value = tk.MK;
                    matkhau2.Value = tk.MK;
                }
                }

            }
            //{
            //    //if (Session["name"] == null)
            //    //{
            //    //    Response.Redirect("dangnhap.aspx");
            //    //}
            //    //else
            //    //{
            //    //    Response.Write("Xin chao: " + Session["name"]);
            //    //}
            //    List<TaiKhoan> danhsach;
            //    danhsach = (List<TaiKhoan>)Application["danhsach_tk"];

            //    if (IsPostBack)
            //    {
            //        if (Request.Form["luu"] == "Lưu")
            //        {
            //            TaiKhoan tk = new TaiKhoan();
            //            tk.HoTen = Request.Form["hoten"];
            //            tk.NgaySinh = Request.Form["ngaysinh"];
            //            tk.DiaChi = Request.Form["diachi"];
            //            tk.Email = Request.Form["email"];
            //            tk.SDT = Request.Form["sdt"];
            //            tk.MatKhau1 = Request.Form["matkhau1"];
            //            tk.MatKhau2 = Request.Form["matkhau2"];
            //            danhsach.Add(tk);
            //            Application["danhsach_tk"] = danhsach;
            //            Response.Redirect("home1.aspx");
            //        }
            //        if (Request.Form["sua"] == "Sửa")
            //        {
            //            Response.Write("Ban vua bam sua");
            //            foreach (TaiKhoan tk in danhsach)
            //            {
            //                if (String.Equals(Request.Form["hoten"], tk.HoTen))
            //                {
            //                    tk.HoTen = Request.Form["hoten"];
            //                    tk.NgaySinh = Request.Form["ngaysinh"];
            //                    tk.DiaChi = Request.Form["diachi"];
            //                    tk.Email = Request.Form["email"];
            //                    tk.SDT = Request.Form["sdt"];
            //                    Response.Redirect("doiMK.aspx");
            //                }
            //            }
            //        }

            //        if (Request.Form["dangxuat"] == "Đăng xuất")
            //        {
            //            Session.Remove("name");
            //            Session.Abandon();
            //            Response.Redirect("dangnhap.aspx");
            //        }

            //        if (Request.Form["xoa"] == "Xóa")
            //        {
            //            foreach (TaiKhoan tk in danhsach)
            //            {
            //                if (String.Equals(Request.Form["hoten"], tk.HoTen))
            //                {
            //                    danhsach.Remove(tk);
            //                    Response.Redirect("dangki.aspx");
            //                }
            //            }
            //        }
            //    }

            //    if (Request.QueryString["email"] != "")
            //    {
            //        //hoten.Value = Request.QueryString["hoten"];
            //        //ngaysinh.Value = Request.QueryString["ngaysinh"];
            //        //sdt.Value = Request.QueryString["sdt"];
            //        email.Value = Request.QueryString["email"];
            //        //diachi.Value = Request.QueryString["diachi"];
            //        matkhau1.Value = Request.Form["matkhau1"];
            //        matkhau2.Value = Request.Form["matkhau2"];
            //    }
            //    string chuoi = "";
            //    chuoi += "<table border ='1''>";
            //    chuoi += "<tr>";
            //    chuoi += "<td>STT</td>";
            //    chuoi += "<td>Ho va ten</td>";
            //    chuoi += "<td>Ngay sinh</td>";
            //    chuoi += "<td>SDT</td>";
            //    chuoi += "<td>Email</td>";
            //    chuoi += "<td>Dia chi</td>";
            //    chuoi += "<td>Mat khau 1</td>";
            //    chuoi += "<td>Mat khau 2</td>";
            //    chuoi += "<td>Tac vu</td>";
            //    chuoi += "</tr>";
            //    int i = 1;
            //    foreach (TaiKhoan tk in danhsach)
            //    {
            //        chuoi += "<td>" + (i++) + "</td>";
            //        chuoi += "<td>" + tk.HoTen + "</td>";
            //        chuoi += "<td>" + tk.NgaySinh + "</td>";
            //        chuoi += "<td>" + tk.SDT + "</td>";
            //        chuoi += "<td>" + tk.Email + "</td>";
            //        chuoi += "<td>" + tk.DiaChi + "</td>";
            //        chuoi += "<td>" + tk.MatKhau1 + "</td>";
            //        chuoi += "<td>" + tk.MatKhau2 + "</td>";
            //        chuoi += "<td><a href='doiMK.aspx?hoten=" + tk.HoTen + "&ngaysinh=" + tk.NgaySinh + "&sdt=" + tk.SDT + "&email=" + tk.Email + "&diachi=" + tk.DiaChi + "&matkhau1=" + tk.MatKhau1 + "&matkhau2=" + tk.MatKhau2 + "'>Sửa</td>";


            //        chuoi += "</tr>";
            //    }
            //    chuoi += "</table>";
            //    bang.InnerHtml = chuoi;
            //}
            {
                //if (Session["name"] == null)
                //{
                //    Response.Redirect("dangnhap.aspx");
                //}
                //else
                //{
                //    Response.Write("Xin chao: " + Session["name"]);
                //}
                List<TaiKhoan> danhsach;
                danhsach = (List<TaiKhoan>)Application["danhsach_tk"];

                if (IsPostBack)
                {
                    if (Request.Form["luu"] == "Lưu")
                    {
                        TaiKhoan tk = new TaiKhoan();
                        tk.HoTen = Request.Form["hoten"];
                        tk.NgaySinh = Request.Form["ngaysinh"];
                        tk.DiaChi = Request.Form["diachi"];
                        tk.Email = Request.Form["email"];
                        tk.SDT = Request.Form["sdt"];
                        tk.MK = Request.Form["matkhau1"];
                        tk.MK = Request.Form["matkhau2"];
                        //tk.TAIKHOAN = (string)Session["name"];
                        danhsach.Add(tk);
                        Application["danhsach_tk"] = danhsach;
                        Response.Redirect("doiMK.aspx");
                    }
                    if (Request.Form["sua"] == "Sửa")
                    {
                        Response.Write("Ban vua bam sua");
                        foreach (TaiKhoan tk in danhsach)
                        {
                            if (
                                String.Equals(Request.Form["email"], tk.Email)
                                //&& String.Equals(Request.Form["hoten"], tk.HoTen)
                                //&& String.Equals(Request.Form["sdt"], tk.SDT)
                                //&& String.Equals(Request.Form["ngaysinh"], tk.NgaySinh)
                                //&& String.Equals(Request.Form["diachi"], tk.DiaChi)                                
                                )
                            {
                                tk.HoTen = Request.Form["hoten"];
                                tk.NgaySinh = Request.Form["ngaysinh"];
                                tk.DiaChi = Request.Form["diachi"];
                                tk.Email = Request.Form["email"];
                                tk.SDT = Request.Form["sdt"];
                                tk.MK = Request.Form["matkhau1"];
                                tk.MK = Request.Form["matkhau2"];
                                //tk.TAIKHOAN = (string)Session["name"];
                                Response.Redirect("doiMK.aspx");
                            }
                        }
                    }

                    if (Request.Form["dangxuat"] == "Đăng xuất")
                    {
                        Session.Remove("name");
                        Session.Abandon();
                        Response.Redirect("dangnhap.aspx");
                    }

                    //if (Request.Form["xoa"] == "Xóa")
                    //{
                    //    //foreach (TaiKhoan tk in danhsach)
                    //    //{
                    //    //    if (String.Equals(Request.Form["email"], tk.Email))
                    //    //    {
                    //    //        danhsach.Remove(tk);
                    //    //        //Response.Redirect("dangki.aspx");
                    //    //    }
                    //    //}
                    //    Response.Write("Ban vua bam sua");
                    //    foreach (TaiKhoan tk in danhsach)
                    //    {
                    //        if (
                    //            String.Equals(Request.Form["email"], tk.Email)
                    //            //&& String.Equals(Request.Form["hoten"], tk.HoTen)
                    //            //&& String.Equals(Request.Form["sdt"], tk.SDT)
                    //            //&& String.Equals(Request.Form["ngaysinh"], tk.NgaySinh)
                    //            //&& String.Equals(Request.Form["diachi"], tk.DiaChi)                                
                    //            )
                    //        {
                    //            tk.HoTen = Request.Form[""];
                    //            tk.NgaySinh = Request.Form[""];
                    //            tk.DiaChi = Request.Form[""];
                    //            tk.Email = Request.Form[""];
                    //            tk.SDT = Request.Form[""];
                    //            tk.MatKhau1 = Request.Form[""];
                    //            tk.MatKhau2 = Request.Form[""];
                    //            Response.Redirect("doiMK.aspx");
                    //        }
                    //    }
                    //}
                }
                foreach (TaiKhoan tk in danhsach)
                {
                    if (Request.Form["xoa"] == tk.Email )
                    {
                        danhsach.Remove(tk);
                        break;
                    }
                }
                if (Request.QueryString["email"] != ""
                    )
                {
                    hoten.Value = Request.QueryString["hoten"];
                    ngaysinh.Value = Request.QueryString["ngaysinh"];
                    sdt.Value = Request.QueryString["sdt"];
                    email.Value = Request.QueryString["email"];
                    diachi.Value = Request.QueryString["diachi"];
                    matkhau1.Value = Request.Form["matkhau1"];
                    matkhau2.Value = Request.Form["matkhau2"];
                }
                string chuoi = "";
                chuoi += "<table  >";
                chuoi += "<tr hidden='hidden'>";
                chuoi += "<td hidden='hidden'>STT</td>";
                chuoi += "<td hidden='hidden'>Ho va ten</td>";
                chuoi += "<td hidden='hidden'>Ngay sinh</td>";
                chuoi += "<td hidden='hidden'>SDT</td>";
                chuoi += "<td hidden='hidden'>Email</td>";
                chuoi += "<td hidden='hidden'>Dia chi</td>";
                chuoi += "<td hidden='hidden'>Mat khau 1</td>";
                chuoi += "<td hidden='hidden'>Mat khau 2</td>";
                chuoi += "<td hidden='hidden'>Tac vu</td>";
                chuoi += "</tr>";
                int i = 1;
                foreach (TaiKhoan tk in danhsach)
                {
                    chuoi += "<td hidden='hidden'>" + (i++) + "</td>";
                    chuoi += "<td hidden='hidden'>" + tk.HoTen + "</td>";
                    chuoi += "<td hidden='hidden'>" + tk.NgaySinh + "</td>";
                    chuoi += "<td hidden='hidden'>" + tk.SDT + "</td>";
                    chuoi += "<td hidden='hidden'>" + tk.Email + "</td>";
                    chuoi += "<td hidden='hidden'>" + tk.DiaChi + "</td>";
                    chuoi += "<td hidden='hidden'>" + tk.MK + "</td>";
                    chuoi += "<td hidden='hidden'>" + tk.MK+ "</td>";
                    chuoi += "<td><button class='btn'><a class='textA' href='doiMK.aspx?hoten=" + tk.HoTen + "&ngaysinh=" + tk.NgaySinh + "&sdt=" + tk.SDT + "&email=" + tk.Email + "&diachi=" + tk.DiaChi + "&matkhau1=" + tk.MK + "&matkhau2=" + tk.MK + "'>Xem</button></td>";
                    //chuoi += "<td><input class=\"btn btn-registration\" type='submit' name='xoa' value=\"Xoá\"'" + tk.Email + "'/></td>";
                    //< input class="btn btn-registration" type="reset" name="huy" id="huy" value="Huỷ" />
                    chuoi += "<td class='remove'><button type='submit' class='btn' name='xoa' value='" + tk.Email + "'>Xóa</button></td>";
                    chuoi += "</tr>";
                }
                chuoi += "</table>";
                bang.InnerHtml = chuoi;
            }

        }
    }
}