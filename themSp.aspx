<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="themSp.aspx.cs" Inherits="BTL_WEB.themSp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="UTF-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link rel="stylesheet" href="styles/base.css"/> 
    <link rel="stylesheet" href="fonts/fontawesome-free-5.15.3-web/fontawesome-free-5.15.3-web/css/all.min.css"/>
    <style>
        .add-product-container{
             margin: 50px auto 0;     
             max-width: 500px;       
             background-color: rgba(166, 193, 255, 0.902); 
             border: 3px solid rgba(0, 50, 249, 0.902);  
             border-radius: 5px;
             box-sizing: border-box;  padding: 20px;
        }
        .add-product-form{
            width: 100%; font-size:15px;
        }
        .add-product-group{
             height: 55px; margin: 5px 0; align-items: center;
        }
        .add-product-input{
            width: 100%; height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
               <div class="add-product-container" style="" runat="server">
        <div class="add-product-form" style=" ">
           <div class="add-product-group" style="  ">
               <h3 style="min-width: 170px;">Mã sản phẩm : </h3>
               <input type="text" id="idSp" class="add-product-input" style="" runat="server"/>
               <div id="errId" style="font-size: 14px; text-align: right;" runat="server" ></div> 
           </div>
           <div class="add-product-group" >
               <h3 style="min-width: 170px;">Tên sản phẩm : </h3>
               <input type="text" id="tenSp" class="add-product-input" style=" text-transform:capitalize;" runat="server"/>
               <div id="errName" style="font-size: 14px; text-align: right;" runat="server"></div> 
            </div>
            <div class="add-product-group" >
               <h3 style="min-width: 170px;">CPU : </h3>
               <input type="text" id="cpu" class="add-product-input" runat="server"/>
                <div id="errCpu" style="font-size: 14px; text-align: right;" runat="server"></div> 
           </div>
            <div class="add-product-group" >
               <h3 style="min-width: 170px;">RAM : </h3>
               <input type="text" id="ram" class="add-product-input" style="width: 100%; height: 23px; " runat="server"/>
                <div id="errRam" style="font-size: 14px; text-align: right;" runat="server"></div> 
           </div>
            <div class="add-product-group" >
               <h3 style="min-width: 170px;">Ổ cứng : </h3>
               <input type="text" id="hd" class="add-product-input" runat="server"/>
                <div id="errHd" style="font-size: 14px; text-align: right;" runat="server"></div> 
           </div>
            <div class="add-product-group" >
               <h3 style="min-width: 170px;">Hệ điều hành : </h3>
               <input type="text" id="hdh" class="add-product-input" runat="server"/>
                <div id="errHdh" style="font-size: 14px; text-align: right;" runat="server"></div> 
           </div>
            <div class="add-product-group" >
               <h3 style="min-width: 170px;">Giá : </h3>
               <input type="text" id="gia" class="add-product-input" runat="server"/>
                <div id="errPrice" style="font-size: 14px; text-align: right;" runat="server"></div> 
           </div>
            <div class="add-product-group" >
               <h3 style="min-width: 170px;">Phần trăm giảm giá: </h3>
               <input type="text" id="discount" class="add-product-input" runat="server"/>
               <div id="errDiscount" style="font-size: 14px; text-align: right;" runat="server"></div> 
           </div>
            <div class="add-product-group" >
               <h3 style="min-width: 170px;">Ảnh: </h3>
               <input type="text" id="anh" class="add-product-input" runat="server"/>
                
               <div id="Div1" style="font-size: 14px; text-align: right;" runat="server"></div> 
           </div>
        </div>
           <div id="notify" style="height:30px; text-align:center; font-size:18px; font-weight:600;" runat="server"></div>
        <div class="add-product-controller" style=" display:flex ; justify-content: space-around; ">
            <a class="btn move-to-home" href="Home.aspx">Trở về trang chủ</a>
            <input type="submit" value="Thêm sản phẩm" name="addproduct" class="btn"/>
             <input class="btn btn-registration" type="reset" name="huy" id="huy" value="Huỷ" />
        </div>
    </div>

        </div>
    </form>
</body>
</html>
