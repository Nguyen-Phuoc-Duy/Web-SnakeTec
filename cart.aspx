<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="BTL_WEB.cart" %>
<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div>
              <div class="cart-container" runat="server">
        <div class="grid wide">
            <label for=""> <h1>GIỎ HÀNG</h1></label>
            <div class="row">
                <table class="layout-cart col c-7 t-12 m-12" id="cart_list_layout">
                <thead>
                    <tr>
                        <th class="image">
                            Sản phẩm
                        </th>
                        <th class="item">
                            Tên sản phẩm
                        </th>
                        <th class="qty">
                            Số lượng
                        </th>
                        <th class="price">
                            Giá tiền
                        </th>
                        <th class="remove">
                            Tác vụ
                        </th>
                    </tr>
                </thead>
                <tbody id="cart_list" runat="server">
                    <tr>
                        <td class="image">
                            <div class="product-img">
                                <a href="">
                                    <img src="/folder/img/product/screen/man-hinh-gaming-asus-tuf-vg30vql1a-1-228x228.jpg" alt="">
                                </a>
                            </div>
                        </td>
                        <td class="item">
                            <a href="">
                                <strong>Lenovo s145</strong>
                            </a>
                        </td>
                        <td class="qty">
    
                        </td>
                        <td class="price">
                            1500000
                        </td>                       
                    </tr>
                </tbody>
            </table>
            <div class="cart-payment c-3 t-12 m-12">
                <label for=""><h2>THANH TOÁN</h2></label>
                <p class="cart-payment-text">Quý khách vui lòng xem kỹ các sản phẩm trong giỏ hàng sau đó ấn nút thanh toán.</p>
                <p class="cart-total-price"><span>Tổng tiền : </span><span id="cart_total_price" runat="server">23000000</span></p>
                <button class="btn btn-payment">Thanh toán</button>
            </div>
            </div>
        </div>      
    </div>
        </div>
    </form>
</asp:Content>
