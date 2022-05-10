function processorder() {
    const img = document.getElementById('product-info-img').getAttribute('src');
    const id = document.getElementById('product-info-img').getAttribute('alt');
    const name = document.querySelector('.product-name').innerText;
    const price = document.querySelector('.new-price1').innerText;
  
    window.location.href = `OrderProcess.aspx?id=${id}&name=${name}&img=${img}&price=${price}`;
};