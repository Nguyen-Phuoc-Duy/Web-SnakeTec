<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="dangnhap.aspx.cs" Inherits="BTL_WEB.dangnhap" %>
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
    <link rel="stylesheet" href="styles/registration.css?v=1" />
    <link rel="stylesheet" href="styles/login.css?v=1" />
    <style>
        body{
            background: linear-gradient(to right, #448855, #508ea3, #1e5b75);
        }
    </style>
</head>
    <body>
           <form id="form1" runat="server" method="post">    
           <div class="login-container">
        <h2><label for="">ĐĂNG NHẬP</label></h2>
        <div class="form-group">
            <label for="">Tài khoản : </label>
            <input type="text" name="email" id="email" placeholder="  Email...">
        </div>
        <div class="form-group">
            <label for="">Mật khẩu : </label>
            <input type="password" name="mk" id="mk" placeholder="  Mật khẩu">
        </div>
               <div id="loginErr3" runat="server" style="font-size:20px; color:red; font-weight:600;"></div>
        <div class="login-controller">
            <button class="btn btn-login" type="submit" value="Đăng nhập" id="dangnhap" name="dangnhap">Đăng nhập</button>      
        <input class="btn btn-registration" type="reset" name="huy" id="huy" value="Huỷ" />
        </div>  
               <br />
         <center><h2 id="login_err" runat="server"></h2></center>
        <div class="move-to-registration">
            Bạn chưa có tài khoản ? <a href="dangki.aspx">Đăng kí</a>
        </div>      
    </div>
    </form>
        </body>
    </html>
 
    