<%@ Page Language="C#"  MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BTL_WEB.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
             <div class="body-container">
                <div class="grid wide">
                    <section class="slide-area">
                        <div class="slide-gr">
                            <div class="slide">
                                <img class="slide-img" src="image/slide/slide1.png"/>
                            </div>                      
                        </div>
                        <button class="slide-btn-left" onclick="changeslide(-1)"><i class="fas fa-chevron-left"></i></button>
                        <button class="slide-btn-right" onclick="changeslide(1)"><i class="fas fa-chevron-right"></i></button>
                    </section>
                  
                    <section class="product-home">
                          <div class="product-title-bar">
                             <div class="product-title-name">
                                <span>laptop acer</span>
                             </div>
                             <a class="product-title-viewall" href="AcerPage.aspx">
                                <span>xem tất cả +</span>
                             </a>
                          </div>
                         <div class="product"> 
                              <button class="fas fa-chevron-left product-preBtn"></button>
                              <button class="fas fa-chevron-right product-nxtBtn"></button>   
                            <div class="product-container sm-gutter" id="AcerList" runat="server">                                   
                          </div>

                         </div>
                         
                    </section>
                     <section class="product-home">
                          <div class="product-title-bar">
                             <div class="product-title-name">
                                <span>laptop asus</span>
                             </div>
                             <a class="product-title-viewall" href="AsusPage.aspx">
                                <span>xem tất cả +</span>
                             </a>
                          </div>
                         <div class="product"> 
                              <button class="fas fa-chevron-left product-preBtn"></button>
                              <button class="fas fa-chevron-right product-nxtBtn"></button>   
                            <div class="product-container sm-gutter" id="AsusList" runat="server">                                   
                          </div>

                         </div>
                         
                    </section>
                      <section class="product-home">
                          <div class="product-title-bar">
                             <div class="product-title-name">
                                <span>laptop lenovo</span>
                             </div>
                             <a class="product-title-viewall" href="LenovoPage.aspx">
                                <span>xem tất cả +</span>
                             </a>
                          </div>
                         <div class="product"> 
                              <button class="fas fa-chevron-left product-preBtn"></button>
                              <button class="fas fa-chevron-right product-nxtBtn"></button>   
                            <div class="product-container sm-gutter" id="LenovoList" runat="server">                                   
                          </div>

                         </div>
                         
                    </section>
                </div>
            </div>
</asp:Content>

            
            

       
    
