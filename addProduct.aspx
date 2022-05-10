<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addProduct.aspx.cs" Inherits="BTL_WEB.addProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <title>Thêm sản phẩm</title>
       <meta charset="UTF-8"/>
       <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
        <link rel="stylesheet" href="styles/style.css?v122"/>
        <link rel="stylesheet" href="styles/grid.css"/> 
       <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
       <link rel="stylesheet" href="styles/base.css?v122"/>
      <link rel="stylesheet" href="fonts/fontawesome-free-5.15.3-web/fontawesome-free-5.15.3-web/css/all.min.css"/>
       <link rel="stylesheet" href="styles/header-main.css"/>
       <link rel="stylesheet" href="styles/responsive.css"/>
       <style>
        .form-sanPham{     
            margin: 240px auto 30px;
            width: 400px;
            text-align: center;
        }
        .form-group{
            margin: 10px 0 10px 0;
        }
        label{
            float: left;
            margin-bottom: 5px;
        }
           input{
               width: 100%;
           }
           .btn{
     height: 40px;
    padding: 0 11px 0 11px;
    background-color: rgb(10, 89, 158);
    border: none;
    border-radius: 3px;
    text-decoration: none;
    font-size: 1.4rem;
    cursor: pointer;
    transition: 0.3s;
    display: flex;
    justify-content: center;
    align-items: center;
    line-height: 1.4rem;
    color: floralwhite ;
}
    </style>
</head>
<body>
    <form id="form1" runat="server" method="post">
        <div>
              <header class="header">
                <section class="banner-top">
                    <img class="banner-top-img" src="image/banner-top/bn-top4.jpg"/>
                </section>
                <section class="header-top">
                    <div class="header-logo-field">
                        <a href="Home.aspx" class="header-logo-link">
                            <img src="image/logo/Free_Sample_By_Wix.jpg" alt="snaketec" class="header-logo-img"/>
                        </a>
                    </div>
                    <div class="header-container">
                        <div class="header-mast">
                            <div class="header-search" method="post">
                                <div class="header-search -field">
                                    <input type="text" class="header-search-input" placeholder="Tìm kiếm..." />
                                </div>
                                <div class="header-search-btn-area">
                                   <button type="submit" class="btn header-search-btn">
                                      <i class="fas fa-search"></i>
                                      <span>Tìm kiếm</span>
                                   </button>
                                 </div>
                            </div>
                            <div class="header-user">
                                <a class="header-user-item" href="#">
                                    <i class="fas fa-user-plus header-user-icon"></i>
                                    <span class="header-user-text">Đăng kí</span>
                                </a>
                                <a class="header-user-item" href="#">
                                    <i class="fas fa-sign-in-alt header-user-icon"></i>
                                    <span class="header-user-text">Đăng nhập</span>
                                </a>
                                <a class="header-user-item" href="addProduct.aspx">
                                    <i class="fas fa-tags header-user-icon"></i>
                                    <span class="header-user-text">Thêm sản phẩm</span>
                                </a>
                                <a class="header-user-item" href="#">
                                    <i class="fas fa-user-plus header-user-icon"></i>
                                    <span class="header-user-text">Giỏ hàng</span>
                                </a>
                                    <a href="#" class="sticker-cart">
                                    <i class="fas fa-cart-plus header-user-icon"></i>
                                </a>
                            </div>
                        </div>
                        <div class="header-info">
                            <div class="header-info-view">
                                 <p>Hotline : (024) 3628.8790 - (086) 830.2123 - Email : cskh@snaketec.vn</p>
                            </div>
                        </div>
                    </div>
                </section>
                <section class="header-main">
                    <div class="grid wide">
                        <div class="header-main-navbar">
                            <div class="header-menu">
                                <div class="header-menu-btn btn">
                                    <i class="fas fa-desktop"></i>
                                    <span>Danh mục sản phẩm</span>
                                    <i class="fas fa-chevron-down"></i>
                                    <div class="mega-menu-area">
                                        <ul class="mega-menu-list">
                                            <li class="mega-menu-item">
                                                <a href="#" class="menu-item-link">
                                                    <p>laptops</p><i class="fas fa-chevron-right"></i>
                                                </a>
                                            </li>
                                            <li class="mega-menu-item">
                                                <a href="#" class="menu-item-link">
                                                    <p>laptops</p><i class="fas fa-chevron-right"></i>
                                                </a>
                                            </li>
                                            <li class="mega-menu-item">
                                                <a href="#" class="menu-item-link">
                                                    <p>laptops</p><i class="fas fa-chevron-right"></i>
                                                </a>
                                            </li>
                                            <li class="mega-menu-item">
                                                <a href="#" class="menu-item-link">
                                                    <p>laptops</p><i class="fas fa-chevron-right"></i>
                                                </a>
                                                <div class="header-sub-menu-area">
                                                    <div class="header-sub-menu-list">
                                                        <div class="header-sub-item">
                                                            <a class="header-sub-item-link">Laptop gaming</a>
                                                        </div>
                                                        <div class="header-sub-item">
                                                            <a class="header-sub-item-link">Laptop văn phòng</a>
                                                        </div>
                                                    </div>
                                                    <div class="banner-sub-menu">   
                                                        <div class="banner-sub-menu-area">
                                                             <img src="image/laptops/Laptop.png" alt="" class="header-sub-item-img"/> 
                                                        </div>                                                                                                                                             
                                                    </div>
                                                </div>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div class="header-navbar-list">
                                <a href="#" class="header-navbar-item">
                                    <div class="item-field">
                                        <i class="fas fa-money-check-alt item-icon"></i>
                                        <span>hướng dẫn thanh toán</span>
                                    </div>
                                </a>
                                <a href="#" class="header-navbar-item">
                                    <div class="item-field">
                                        <i class="fas fa-money-bill item-icon"></i>
                                        <span>hỗ trợ trả góp</span>
                                    </div>
                                </a>
                                <a href="#" class="header-navbar-item">
                                    <div class="item-field">
                                        <i class="fas fa-wrench item-icon"></i>
                                        <span>chính sách bảo mật</span>
                                    </div>
                                </a>
                                <a href="#" class="header-navbar-item">
                                    <div class="item-field">
                                        <i class="fas fa-truck item-icon"></i>
                                        <span>chính sách vận chuyển</span>
                                    </div>
                                </a>
                            </div>
                        </div>
                    </div>
                </section>
            </header>
             <div class="form-sanPham">      
        <div class="form-group">
            <label>Tên sản phẩm</label><br>
            <input type="text" id="tensanpham1" class="form-product-name"/>
        </div>
        <div class="form-group">
            <label>CPU</label><br>
            <input type="text" id="cpu1"  class="form-product-cpu"/>
        </div>
        <div class="form-group">
            <label>Ram</label><br>
            <input type="text"  id="ram1" class="form-product-ram"/>
        </div>
        <div class="form-group">
            <label>Ổ cứng</label><br>
            <input type="text"  id="ocung1" class="form-product-hdd"/>
        </div>
        <div class="form-group">
            <label>Hệ điều hành</label><br>
            <input type="text"  id="hedieuhanh1" class="form-product-os"/>
        </div>
                 <div class="form-group">
            <label>Ảnh</label><br>
            <input type="text"  id="imgSp1" class="form-product-oldPrice"/>
        </div>
                 <div class="form-group">
            <label>ID</label><br>
            <input type="number"  id="id1" class="form-product-oldPrice"/>
        </div>
        <div class="form-group">
            <label>Giá cũ</label><br>
            <input type="number"  id="giaCu1" class="form-product-oldPrice"/>
        </div>
        <div class="form-group">
            <label>Giá mới</label><br>
            <input type="number"   id="giaMoi1" class="form-product-newPrice"/>
        </div>
                 <center><div id="regis_err" runat="server"></div></center>
        <button class="form-product-btn btn" type="submit">Thêm sản phẩm</button>
    </div>
        </div>
    </form>

    
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
                    
     <div class="nav-overlay" onclick="showSidebarMenu()"></div>
 <nav class="sidebar-menu-wrapper">  
   <h3 class="sidebar-menu-title">
     <span>MENU</span>
   </h3> 
   <div class="sidebar-menu-user">
     <a class="sidebar-user-item">
       <i class="fas fa-user-plus"></i>
       <span>Đăng ký</span>
     </a>
     <a class="sidebar-user-item">
       <i class="fas fa-sign-in-alt"></i>
       <span>Đăng nhập</span>
     </a>
   </div>  
   <h4 class="sidebar-header-menu">
     <span>Danh mục</span>
   </h4>
   <ul class="sidebar-menu-list">
     <li class="sidebar-menu-item">
       <a href="#" class="sidebar-menu-item-link">
         <div>
           <i class="fas fa-laptop"></i>
          <span>laptops</span>
        </div>          
           <span class="sidebar-submenu-btn"> 
             <i class="fas fa-chevron-right sidebar-submenu-btn-icon"></i>
          </span> 
        </a>       
      <ul class="sidebar-submenu-list">
        <li class="sidebar-submenu-item ">       
             <a href="#" class="sidebar-submenu-link">
               <div>          
                 <i class="far fa-circle sidebar-submenu-item-icon"></i>
                 <span>Laptop văn phòng theo hãng</span>
               </div>             
               <span class="sidebar-menu-sub-cat-btn">
                 <i class="fas fa-chevron-right sidebar-sub-cat-btn-icon"></i> 
               </span>
             </a>  
             <ul class="sidebar-sub-cat-list">
               <li class="sidebar-sub-cat-item">
                 <a href="#" class="sidebar-sub-cat-link">
                   <i class="fas fa-circle"></i>
                   <span>Acer</span> 
                 </a>              
               </li>
               <li class="sidebar-sub-cat-item">
                 <a href="#" class="sidebar-sub-cat-link">
                   <i class="fas fa-circle"></i>
                   <span>Lenovo</span> 
                 </a> 
               </li>
             </ul>        
        </li>
        <li class="sidebar-submenu-item">            
         <a href="#" class="sidebar-submenu-link">
           <div>          
             <i class="far fa-circle sidebar-submenu-item-icon"></i>
             <span>Laptop gaming theo hãng</span>
           </div>             
           <span class="sidebar-menu-sub-cat-btn">
             <i class="fas fa-chevron-right sidebar-sub-cat-btn-icon"></i> 
           </span>
         </a>   
         <ul class="sidebar-sub-cat-list">
           <li class="sidebar-sub-cat-item">
             <a href="#" class="sidebar-sub-cat-link">
               <i class="fas fa-circle"></i>
               <span>Acer</span> 
             </a>              
           </li>
           <li class="sidebar-sub-cat-item">
             <a href="#" class="sidebar-sub-cat-link">
               <i class="fas fa-circle"></i>
               <span>Lenovo</span> 
             </a> 
           </li>
         </ul>          
       </li>
      </ul>        
    </li>
    <li class="sidebar-menu-item">
     <a href="#" class="sidebar-menu-item-link">
       <div>
         <i class="fas fa-desktop"></i>
        <span>PC</span>
      </div>          
         <span class="sidebar-submenu-btn"> 
           <i class="fas fa-chevron-right sidebar-submenu-btn-icon"></i>
        </span> 
      </a>       
    <ul class="sidebar-submenu-list">
      <li class="sidebar-submenu-item ">       
           <a href="#" class="sidebar-submenu-link">
             <div>          
               <i class="far fa-circle sidebar-submenu-item-icon"></i>
               <span>PC văn phòng theo hãng</span>
             </div>             
             <span class="sidebar-menu-sub-cat-btn">
               <i class="fas fa-chevron-right sidebar-sub-cat-btn-icon"></i> 
             </span>
           </a>  
           <ul class="sidebar-sub-cat-list">
             <li class="sidebar-sub-cat-item">
               <a href="#" class="sidebar-sub-cat-link">
                 <i class="fas fa-circle"></i>
                 <span>Acer</span> 
               </a>              
             </li>
             <li class="sidebar-sub-cat-item">
               <a href="#" class="sidebar-sub-cat-link">
                 <i class="fas fa-circle"></i>
                 <span>Lenovo</span> 
               </a> 
             </li>
           </ul>        
      </li>
      <li class="sidebar-submenu-item">            
       <a href="#" class="sidebar-submenu-link">
         <div>          
           <i class="far fa-circle sidebar-submenu-item-icon"></i>
           <span>PC gaming theo hãng</span>
         </div>             
         <span class="sidebar-menu-sub-cat-btn">
           <i class="fas fa-chevron-right sidebar-sub-cat-btn-icon"></i> 
         </span>
       </a>   
       <ul class="sidebar-sub-cat-list">
         <li class="sidebar-sub-cat-item">
           <a href="#" class="sidebar-sub-cat-link">
             <i class="fas fa-circle"></i>
             <span>Acer</span> 
           </a>              
         </li>
         <li class="sidebar-sub-cat-item">
           <a href="#" class="sidebar-sub-cat-link">
             <i class="fas fa-circle"></i>
             <span>Lenovo</span> 
           </a> 
         </li>
       </ul>          
     </li>
    </ul>        
  </li>
   </ul>
   
   <h4 class="sidebar-header-menu">
     <span>Thông tin</span>
   </h4>
   <ul class="sidebar-info-list">
     <li class="sidebar-menu-item"> <a href="#" class="sidebar-info-link"><i class="fas fa-tags"></i><span>khuyến mãi</span></a></li>
     <li class="sidebar-menu-item"> <a href="#" class="sidebar-info-link"><i class="fas fa-money-check-alt"></i><span>hướng dẫn thanh toán</span></a></li>
     <li class="sidebar-menu-item"> <a href="#" class="sidebar-info-link"><i class="fas fa-money-bill"></i><span>hướng dẫn trả góp</span></a></li>
     <li class="sidebar-menu-item"><a href="#" class="sidebar-info-link"><i class="fas fa-wrench"></i> <span>chính sách bảo hành</span></a></li>
     <li class="sidebar-menu-item"> <a href="#" class="sidebar-info-link"><i class="fas fa-truck"></i><span>chính sách vận chuyển</span></a></li>
   </ul>
   <div class="sidebar-menu-btn"  onclick="showSidebarMenu()">
     <i class="fas fa-bars sidebar-menu-icon sidebar-menu-icon-open "></i>
     <i class="fas fa-times sidebar-menu-icon sidebar-menu-icon-close  hidden"></i>
   </div> 
 </nav> 
    <footer class="footer">
      <div class="grid wide">
        <div class="row no-gutters footer-container">
          <div class="c-3 t-4 m-10 footer-field">
            <div class="footer-custom">
              <h3>công ty tnhh thương mại snaketec</h3>
              <h3>email : cskh@snaketec.com</h3>
              <h3>thông tin liên hệ :</h3>
              <div class="footer-custom-contact">
                <p>Tổng đài 1 : (024) 3628.8790</p>
                <p>Tổng đài 2 : (086) 830.2123</p>
              </div>
              <a href="#">Hướng dẫn thanh toán</a>
              <a href="#">Hỗ trợ trả góp</a>
              <a href="#">Chính sách bảo hành</a>
              <a href="#">Chính sách giao hàng</a>
            </div>
          </div>
          <div class="c-4 t-4 m-10 footer-field">
             <h3>Hệ Thống cửa hàng</h3>
             <h3>chi nhánh hn :</h3>
             <p>Địa chỉ 1: số 286 Giải Phóng, quận Thanh Xuân , Hà Nội</p>
             <p>Địa chỉ 2: số 91 Chùa Láng, quận Đống Đa , Hà Nội</p>
             <h3>chi nhánh hcm :</h3>
             <p>Địa chỉ : 905 Kha Vạn Cân, Phường Linh Tây, Thành phố Thủ Đức.</p>
          </div>
          <div class="c-3 t-2 m-10 footer-field">
             <h3>follow us !</h3>
             <div class="footer-social">
              <a href="#"><i class="fab fa-facebook-square"></i></a>
              <a href="#"><i class="fab fa-instagram-square"></i></a>
              <a href="#"><i class="fab fa-twitter-square"></i></a>
              <a href="#"><i class="fab fa-youtube"></i></a>
             </div>
          </div>
        </div>
      </div>
   </footer>
    
</body>
    <script src="js/app.js"></script>
</html>--%>
