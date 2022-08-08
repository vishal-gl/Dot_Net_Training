// JavaScript source code
function Validation() {
    var username = document.getElementById('Username').value;
    var password = document.getElementById('Password').value;
    var email = document.getElementById('EmailAddress').value;
    var qualification = document.getElementById('Qualification').value;
    var mobile = document.getElementById('Mobile_No').value;

    if (username == "") {
        document.getElementById('user').innerHTML = "**Please Enter the Username...";
        return false;
    }
    if (password == "" || password.length < 8) {
        document.getElementById('pass').innerHTML = "**Please Enter the valid Password min. 8 Character...";
        return false;

    }
    var atindex = email.indexOf('@');
    var dotindex = email.indexOf('.');
    var endl = email.length;

    if (email.length < 7 || atindex < 2 || dotindex < 4 || dotindex - atindex < 2 || endl - dotindex < 3) {
        document.getElementById('email').innerHTML = "**Please Enter the Valid Email Id length more than 6 character...";

    }
    if{
        if(mobile.length < 10 || mobile == "[0 - 9]{ 3 } -[0 - 9]{ 3 } -[0 - 9]{ 4 }"){
        document.getElementById('mobile').innerHTML = "**Please Enter the Valid Mobile Number...";
    }
    else {
        document.links()
    }



    }

}
