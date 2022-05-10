
/* slide */
var slideImg = document.querySelector('.slide-img');

var num_slide = 2;
var slideImgs = [
    "image/slide/slide1.png",
    "image/slide/slide2.png",
    "image/slide/slide3.png"
];

function changeslide(n) {
    if (n === -1) {
        num_slide--;
        if (num_slide < 0) {
            num_slide = slideImgs.length - 1;
        }
    }
    if (n === 1) {
        num_slide++;
        if (num_slide > slideImgs.length - 1) {
            num_slide = 0;
        }

    }
    slideImg.src = slideImgs[num_slide];
}
setInterval(() => {
    changeslide(1);
}, 3000);
