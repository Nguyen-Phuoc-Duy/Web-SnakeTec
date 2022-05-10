<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userInfo.aspx.cs" Inherits="BTL_WEB.userInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .user-info-container{           
            width: 450px;
            font-size: 20px;            
            font-family: 'Times New Roman', Times, serif;
            margin:150px auto;
            background-color: rgb(228, 237, 250);
            border: 3px solid rgb(10, 89, 158);
            border-radius: 4px;
        }
        .user-label{
            margin-top: 20px;
            text-align: center;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            color:rgb(10, 89, 158) ;
            font-weight: 550;
            font-size: 22px;
        }
        .user-info-form{
            padding: 13px 20px;
        }
        .user-info-group{
            display: flex;
            margin: 4px 0 4px 10px;
        }
        .user-info-label{
            width: 160px;
            color:rgb(0, 63, 118) ;
            
        }
        .user-info-content{
            font-weight: 550;
            min-width: 200px;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="user-info-container">
        <div class="user-label">THÔNG TIN NGƯỜI DÙNG</div>
        <div class="user-info-form">
            <div class="user-info-group">
                <div class="user-info-label" for="">Tên người dùng : </div><div class="user-info-content" id="user_name" runat="server">Nguyễn Thị Quỳnh Châm </div>
            </div>
            <div class="user-info-group">
                <div class="user-info-label" for="">Ngày sinh : </div><div class="user-info-content" id="user_birthday" runat="server">19/07/2001</div>
            </div>
            <div class="user-info-group">
                <div class="user-info-label" for="">Địa chỉ : </div><div class="user-info-content" id="user_address" runat="server">Thanh Hóa</div>
            </div>
            <div class="user-info-group">
                <div class="user-info-label" for="">Số điện thoại : </div><div class="user-info-content" id="user_sdt" runat="server">0978657483</div>
            </div>
            <div class="user-info-group">
                <div class="user-info-label" for="">Email : </div><div class="user-info-content" id="user_email" runat="server">nguyennhodinh123</div>
            </div>
        </div>
    </div>
        </div>
    </form>
</body>
</html>
