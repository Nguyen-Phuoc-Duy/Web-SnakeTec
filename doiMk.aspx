<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="doiMk.aspx.cs" Inherits="WebST.doiMk" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>SNAKETEC STORE</title>
     <meta charset="UTF-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link rel="stylesheet" href="styles/base.css?v=122"/> 
    <link rel="stylesheet" href="styles/style.css?v=123"/> 
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
    <form id="form1" runat="server" method="post"  onsubmit="return checkdulieu()" >
            <div class="registration-container" >  
        <h2><label for="">Thay đổi thông tin</label> </h2>              
                
            <div class="form-group">             
                <label for="email">Nhập email : </label>
                <label id="loi_email"></label>
                <input name="email" id="email" value=""  runat="server" />             
               <%--<div class="error"></div>--%>
            </div>           
            <div class="form-group">
                <label for="matkhau1">Mật khẩu : </label>   
                 <label id="loi_mk1"></label>
                <input type="password" name="matkhau1" id="matkhau1" value="" runat="server" />
                <%--<div class="error"></div>--%>
            </div>
            <div class="form-group">
                <label for="matkhau2">Xác nhận mật khẩu : </label>
                 <label id="loi_mk2"></label>
                <input type="password" name="matkhau2" id="matkhau2" value="" runat="server" />
                <%--<div class="error"></div>--%>
            </div>

                <div class="form-group">
                <label for="hoten">Tên tài khoản : </label>
                     <label id="loi_hoten"></label>
                <input name="hoten" id="hoten" value=""  runat="server" />
                <%--<div class="error"></div>--%>
            </div>
                <div class="form-group">
                <label for="ngaysinh">Ngày sinh : </label>
                <input type="date" name="ngaysinh" id="ngaysinh" value="" runat="server"  />
                    <label id="loi_ngay"></label>
                <%--<div class="error"></div>--%>
            </div>
            <div class="form-group">
                <label for="sdt">Số điện thoại : </label>
                <label id="loi_sdt"></label>
                <input name="sdt" id="sdt" value="" runat="server" />             
                <%--<div class="error"></div>--%>
            </div>
            <div class="form-group">
                <label for="diachi">Địa chỉ : </label>
                <label id="loi_diachi"></label>
                <input name="diachi" id="diachi" value="" runat="server" />
                <%--<div class="error"></div>--%>
            </div>
                
            <div class="registration-controller">
                <%--<input class="btn btn-registration" type="submit" name="luu" id="luu" value="Lưu"/> --%>
                 <input class="btn btn-registration" type="submit" name="sua" id="sua" value="Sửa"/> 
                <input class="btn btn-registration" type="reset" name="huy" id="huy" value="Huỷ" />
            </div>   
                <br />
            <div id="bang" name="bang"  runat="server"  ></div>  
            <div class="move-to-registration">
                Bạn đã có tài khoản ? <a href="dangnhap.aspx">Đăng nhập</a>
            </div>     
              
    </div>
                </form>

    
</body>
</html>
