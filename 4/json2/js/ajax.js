$(document).ready(function () {
    $('#submit').click(function(){

        var datos = $('#frmajax').serialize();
        
        $.ajax({
            type: "POST",
            url: "../php/insertar.php",
            data: datos,
                success:function(r){
                    if(r==1){
                        alert("Agregado con exito");
                    }
                    else{
                        alert("Agregado con exito");
                    }
                }
        });


    });
});