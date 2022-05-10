var $ = document.querySelector.bind(document);
var $$ = document.querySelectorAll.bind(document);

/* hidden banner top */
window.addEventListener("scroll", function () {
    const bannerTop = $('.banner-top');
    bannerTop.classList.toggle('none', this.window.scrollY > 300);
})

/* sidebar menu */
/* show sidebar */
function showSidebarMenu() {
    $('.sidebar-menu-wrapper').classList.toggle('show');
    $('.nav-overlay').classList.toggle('block');
    $('.sidebar-menu-icon-open').classList.toggle('hidden');
    $('.sidebar-menu-icon-close').classList.toggle('block');
}

/* submenu */
/* show submenu */
var submenuBtn = $$('.sidebar-submenu-btn')
var submenuList = $$('.sidebar-submenu-list');
var sidebarItems = $$('.sidebar-menu-item-link');
var submenuIconBtns = $$('.sidebar-submenu-btn-icon');
submenuBtn.forEach((item, index) => {
    const submenu = submenuList[index];
    const sidebarItem = sidebarItems[index];
    const submenuIconBtn = submenuIconBtns[index];
    item.onclick = function () {
        submenu.classList.toggle('block');
        sidebarItem.classList.toggle('active');
        submenuIconBtn.classList.toggle('rotate');
    }
});

/* show sub cat */
var subcatBtn = $$('.sidebar-menu-sub-cat-btn');
var subcatList = $$('.sidebar-sub-cat-list');
var subcatIconBtns = $$('.sidebar-sub-cat-btn-icon');

subcatBtn.forEach((item, index) => {
    const subcat = subcatList[index];
    const subcatIconBtn = subcatIconBtns[index];
    item.onclick = function () {
        subcat.classList.toggle('block');
        subcatIconBtn.classList.toggle('rotate');
    }
})


//product slider

const productContainers = [...document.querySelectorAll('.product-container')];
const nxtBtn = [...document.querySelectorAll('.product-preBtn')];
const preBtn = [...document.querySelectorAll('.product-nxtBtn')];

productContainers.forEach((item, i) => {
    let containerDimensions = item.getBoundingClientRect();
    let containerWidth = containerDimensions.width;

    nxtBtn[i].addEventListener('click', () => {
        item.scrollLeft -= containerWidth;
    })
    preBtn[i].addEventListener('click', () => {
        item.scrollLeft += containerWidth;
    })
});

