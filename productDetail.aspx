<%@ Page Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="productDetail.aspx.cs" Inherits="BTL_WEB.ChiTietSanPham" %>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="body-container-detail">
           <div class="grid wide">
            <div class="product-info row">
                <div class="col c-4 t-3 m-10">
                    <div class="product-info-img-field" id="product_img" runat="server">
                       
                    </div>                   
                </div>
                <div class="col c-6 t-7 m-10">
                    <div class="product-info-content">
                        <div class="product-info-specifi">
                            <h2 class="product-info-label" id="product_label" runat="server"></h2>
                            <div class="product-info-detail">
                                - NAME: <span id="product_name" class="product-name" runat="server">abc</span><br /><br />
                                - CPU : <span id="product_cpu" runat="server"></span><br /><br />
                                - RAM: <span id="product_ram" runat="server"></span><br /><br />
                                - Ổ cứng: <span id="product_hdd" runat="server"></span>                            
                            </div>
                            <h6 class="detail-warranty">Bảo hàng: 36 tháng</h6>
                            <div class="product-price">
                                <div class="old-price">Giá bán : <span class="price" id="old_price" runat="server"></span> đ</div>
                                <div class="new-price">Giá khuyến mãi : <span class="price new-price1" id="new_price" runat="server"></span> đ</div>
                            </div>          
                                                           
                            <div class="product-buttons">
                                
                                <button class="product-btn-order" type="submit" onclick="processorder()" id="btn_process">Thêm vào giỏ hàng</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>  
    <script src="js/cart.js?v=17"></script>
</asp:Content>

            
