var validEmail =  /^\w+([.-_+]?\w+)*@\w+([.-]?\w+)*(\.\w{2,10})+$/;
var validPassUser = /[a-zA-Z._-]/;

var emailField = document.getElementById('f-email');
var passwordField = document.getElementById('f-pass');
var userField = document.getElementById('f-uname');

if(emailField.value == "") {
    $("#m-email").css("display", "none");
}
if(userField.value == "") {    
    $("#m-uname").css("display", "none");
}

addEventListener("keyup", function(e) {        
    // Validacion email
    // Debajo verifica si el campo esta vacio, si lo esta no sale mensaje
    if(emailField.value == ""  || userField.value == undefined) {
        $("#m-email").css("display", "none");
    }// Verfica que los caracteres sean aceptables
    else if(validEmail.test(emailField.value)){
        // Si el campo es aceptable elimina el mensaje        
        $("#m-email").css("display", "none");    
    }else{
        // si las verificaciones anteriores deniegan el mensaje se muestra
        $("#m-email").css("display", "block");
    }
    
    // Validacion username

    if(userField.value == "" || userField.value == undefined) {
        $("#m-email").css("display", "none");
    }
    else if(validPassUser.test(userField.value)){     
        // minimo-maximo de caracteres que puede poseer
        if((userField.value).length > 8 && (userField.value).length < 64){
            $("#m-uname").css("display", "none");    
        }else{
            $("#m-uname").css("display", "block");
        }
               
    }else{
        $("#m-uname").css("display", "block");
    }

    // Validacion password



})


