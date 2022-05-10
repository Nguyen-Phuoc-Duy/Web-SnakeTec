const username = document.getElementById('hoten');
const email = document.getElementById('email');
const password = document.getElementById('mk');
const retypePassword = document.getElementById('cfmk');
const phone = document.getElementById('sdt');
const address = document.getElementById('diachi');
const btnSubmit = document.getElementById('btn-registration');
const form = document.getElementById('form1');

var check = true;



const isValidEmail = email => {
    const re = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(String(email).toLowerCase());
}


const setError = (element, message) => {
    const inputControl = element.parentElement;
    const errorDisplay = inputControl.querySelector('.error');
    errorDisplay.innerText = message;
    inputControl.classList.add('error');
    inputControl.classList.remove('success');
    check = false;
}

const setSuccess = element => {
    const inputControl = element.parentElement;
    const errorDisplay = inputControl.querySelector('.error');
    errorDisplay.innerText = '';
    inputControl.classList.add('success');
    inputControl.classList.remove('error');
    check = true;

}



const validateInputs = () => {
    const usernameValue = username.value.trim();
    const emailValue = email.value.trim();
    const passwordValue = password.value.trim();
    const retypePasswordValue = retypePassword.value.trim();
    const phoneValue = phone.value.trim();
    const addressValue = address.value.trim();



    if (usernameValue === '') {
        setError(username, 'Vui lòng nhập trường này!');
    } else if (usernameValue.length <= 2) {
        setError(username, 'Tên người dùng không được nhỏ hơn 2 ký tự!');
    } else if (usernameValue.length >= 50) {
        setError(username, 'Tên người dùng không được vượt quá 50 ký tự!');
    } else {
        setSuccess(username);
    }


    if (emailValue === '') {
        setError(email, 'Vui lòng nhập trường này!');
    } else if (!isValidEmail(emailValue)) {
        setError(email, 'Email không đúng định dạng!');
    } else {
        setSuccess(email);
    }


    if (passwordValue === '') {
        setError(password, 'Vui lòng nhập trường này!');
    } else if (passwordValue.length < 6) {
        setError(password, 'Mật khẩu phải nhỏ hơn 6 ký tự!');
    } else {
        setSuccess(password);
    }

    if (phoneValue.length < 10 || phoneValue.length > 10)
        setError(phone, 'Số điện thoại không hợp lệ !');

    if (addressValue === '')
        setError(address, 'Vui lòng nhập trường này !');

    if (retypePasswordValue === '') {
        setError(retypePassword, 'Vui lòng nhập trường này!');
    } else if (passwordValue != retypePasswordValue) {
        setError(retypePassword, 'Mật khẩu không trùng khớp!');
    } else {
        setSuccess(retypePassword);
    }
    return check;
};
