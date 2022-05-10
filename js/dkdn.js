function checkdulieu() {
    ngay = document.getElementById("ngaysinh").value;
    email = document.getElementById("email").value;
    sdt = document.getElementById("sdt").value;
    matkhau1 = document.getElementById("mk").value;
    matkhau2 = document.getElementById("cfmk").value;
    diachi = document.getElementById("diachi").value;
    hoten = document.getElementById("hoten").value;

    loi_ngay = document.getElementById("loi_ngay");
    loi_email = document.getElementById("loi_email");
    loi_sdt = document.getElementById("loi_sdt");
    loi_mk1 = document.getElementById("loi_mk1");
    loi_mk2 = document.getElementById("loi_mk2");
    loi_diachi = document.getElementById("loi_diachi");
    loi_hoten = document.getElementById("loi_hoten");
    checkloi = true;


    //ten
    if (hoten == "") {
        loi_hoten.innerHTML = "Không được bỏ trống";
        checkloi = false;
    }
    else {
        loi_hoten.innerHTML = "";
    }

  
    //email
    if (email == "") {
        loi_email.innerHTML = "Không được bỏ trống";
        checkloi = false;
    }
    else {
        var biena = email.indexOf("@");
        var biencham = email.lastIndexOf(".");
        if (biena < 0 || biencham - biena <= 0) {
            loi_email.innerHTML = "Sai định dạng";
            checkloi = false;
        }
        else {
            loi_email.innerHTML = "";
        }
    }
    //mk1
    if (matkhau1 == "") {
        loi_mk1.innerHTML = "Không được bỏ trống";
        checkloi = false;
    }
    else {
        loi_mk1.innerHTML = "";
    }
    //mk2
    if (matkhau2 == "") {
        loi_mk2.innerHTML = "Không được bỏ trống";
        checkloi = false;
    }
    else {
        if (matkhau2 != matkhau1) {
            loi_mk2.innerHTML = "Mật khẩu không trùng khớp";
            checkloi = false;
        }
        else {
            loi_mk2.innerHTML = "";
        }
    }

    //ngay
    namHienTai = new Date().getFullYear();
    namNhap = new Date(ngay).getFullYear();
    ngay = document.getElementById("ngaysinh").value;
    if (ngay == "") {
        loi_ngay.innerHTML = "Không được bỏ trống";
        checkloi = false;
    }
    else {
        if ((namHienTai - namNhap) >= 18) {
            loi_ngay.innerHTML = "";
        }
        else {
            loi_ngay.innerHTML = "chưa đủ 18 tuổi";
            checkloi = false;
        }
    }
    //sdt
    if (sdt == "") {
        loi_sdt.innerHTML = "Không được bỏ trống ";
        checkloi = false;
    }
    else {
        //loi_sdt.innerHTML = "OK";
        for (var i = 0; i < sdt.length; i++) {
            if (isNaN(sdt.charAt(i))) {
                loi_sdt.innerHTML = "Phải là số";
                checkloi = false;
            }
        }
        if (sdt.charAt(0) != "0") {
            loi_sdt.innerHTML = "Bắt đầu bằng số 0";
            checkloi = false;
        }
        else if (sdt.length != 10) {

            loi_sdt.innerHTML = "Không đủ 10 số";
            checkloi = false;
        }
        else {
            loi_sdt.innerHTML = "";
        }
    }

    //diachi
    if (diachi == "") {
        loi_diachi.innerHTML = "Không được bỏ trống";
        checkloi = false;
    }
    else {
        loi_diachi.innerHTML = "";
    }
    

    return checkloi;
}