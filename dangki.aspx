<%@ Page Language="C#"   AutoEventWireup="true" CodeBehind="dangki.aspx.cs" Inherits="BTL_WEB.dangki" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>SNAKETEC STORE</title>
     <meta charset="UTF-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link rel="stylesheet" href="styles/base.css?v=122"/> 
    <link rel="stylesheet" href="styles/style.css?v=122"/> 
    <link rel="stylesheet" href="fonts/fontawesome-free-5.15.3-web/fontawesome-free-5.15.3-web/css/all.min.css"/>
    <link rel="stylesheet" href="styles/registration.css?v=12" />
    <link rel="stylesheet" href="styles/login.css?v=122" />
   <script  src="/js/dkdn.js"></script>
    <style>
        body{
            background: linear-gradient(to right, #448855, #508ea3, #1e5b75);
        }
    </style>
</head>
    <body>
         <%--<form id="form2" runat="server" method="post" onsubmit="return checkdulieu()">    
           <div class="registration-container">              
               <h2><label>ĐĂNG KÍ</label></h2>   
            <div class="form-group">
                <label for="">Nhập email : </label>
                <input type="text" id="email" name="email" class="" value=""  runat="server">
                <div class="error"><label id="loi_email"></label></div>
            </div>
            <div class="form-group">
                <label for="">Tên tài khoản : </label>
                <input type="text" id="hoten" name="hoten" value=""  runat="server">
                <div class="error"><label id="loi_hoten"></label></div>
            </div>
            <div class="form-group">
                <label for="">Mật khẩu : </label>
                <input type="password" id="mk" name="mk" value=""  runat="server">
                <div class="error"><label id="loi_matkhau1"></label></div>
            </div>
            <div class="form-group">
                <label for="">Xác nhận mật khẩu : </label>
                <input type="password" id="cfmk" name="cfmk" value=""  runat="server">
                <div class="error"><label id="loi_matkhau2"></label></div>
            </div>
            <div class="form-group">
                <label for="">Số điện thoại : </label>
                <input type="text" name="sdt" id="sdt" value=""  runat="server">
                <div class="error"><label id="loi_sdt"></label></div>
            </div>
            <div class="form-group">
                <label for="">Địa chỉ : </label>
                <input type="text" id="diachi" name="diachi" value=""  runat="server">
                <div class="error"><label id="loi_diachi"></label></div>
            </div>
            <div class="form-group">
                <label for="">Ngày sinh : </label>
                <input type="date" id="Date" name="ngaysinh" value=""  runat="server">
                <div class="error"><label id="loi_ngay"></label></div>
            </div>
               <center><div id="regis_err" runat="server"></div></center>
            <div class="registration-controller">
                <input class="btn btn-registration" type="submit" name="dangki" id="dangki" value="Đăng kí"/>         
            </div>   
            <div class="move-to-login">
                Bạn đã có tài khoản ? <a href="dangnhap.aspx">Đăng nhập</a>
            </div>         
         </div>                
    </form>--%>
        {
        <form id="form1" runat="server" method="post"  onsubmit="return checkdulieu()" >
            <div class="registration-container" >  
        <h2><label for="">ĐĂNG KÍ</label> </h2>              
                <div class="form-group">
                <label for="hoten">Tên tài khoản : </label>
                     <label class="error" id="loi_hoten"></label>
                <input name="hoten" id="hoten" value=""  runat="server" />
                <%--<div class="error"></div>--%>
            </div>
            <div class="form-group">             
                <label for="email">Nhập email : </label>
                <label class="error"  id="loi_email"></label>
                <input name="email" id="email" value=""  runat="server" />             
               <%--<div class="error"></div>--%>
            </div>           
            <div class="form-group">
                <label for="matkhau1">Mật khẩu : </label>   
                 <label  class="error"  id="loi_mk1"></label>
                <input type="password" name="mk" id="mk" value="" runat="server" />
                <%--<div class="error"></div>--%>
            </div>
            <div class="form-group">
                <label for="matkhau2">Xác nhận mật khẩu : </label>
                 <label  class="error"  id="loi_mk2"></label>
                <input type="password" name="cfmk" id="cfmk" value="" runat="server" />
                <%--<div class="error"></div>--%>
            </div>
                <div class="form-group">
                <label for="ngaysinh">Ngày sinh : </label>
                <input type="date" name="ngaysinh" id="ngaysinh" value="" runat="server"  />
                    <label  class="error"  id="loi_ngay"></label>
                <%--<div class="error"></div>--%>
            </div>
            <div class="form-group">
                <label for="sdt">Số điện thoại : </label>
                <label  class="error"  id="loi_sdt"></label>
                <input name="sdt" id="sdt" value="" runat="server" />             
                <%--<div class="error"></div>--%>
            </div>
            <div class="form-group">
                <label for="diachi">Địa chỉ : </label>
                <label  class="error"  id="loi_diachi"></label>
                <input name="diachi" id="diachi" value="" runat="server" />
                <%--<div class="error"></div>--%>
            </div>            
                 <center><div id="regis_err" runat="server"></div></center>
            <div class="registration-controller">
                <input class="btn btn-registration" type="submit" name="luu" id="luu" value="Đăng kí"/>      
                <input class="btn btn-registration" type="reset" name="huy" id="huy" value="Huỷ" />
            </div>   
                <br />
            <div id="bang" name="bang"  runat="server" hidden="hidden" >
            <div class="move-to-registration">
                Bạn đã có tài khoản ? <a href="dangnhap.aspx">Đăng nhập</a>
            </div>     
             </div>   
    </div>
                </form>
        }
        <%--<script defer src="js/validateRegis.js?v=123"></script>--%>
         <script  defer src="/js/dkidnhap.js"></script>
    </body>
   </html> 
   


