$(document).ready(function(){

    $('#form_reports').submit(function(e){
        document.getElementById("lol").style.display= 'none'

        let rep_why = $('input[name=rep_why]:checked').val();
        let description = $('#description').val();
        const postData = {
            rep_why: rep_why,
            description: description,    
        }
        $.post("php/insert_reports.php",postData,function (response){
            console.log(response);
        });
        e.preventDefault();
    });



});