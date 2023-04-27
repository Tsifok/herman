$(document).ready(function(){

    $('.formulario-r').submit(function(e){
        document.getElementById("padre-modal").style.display= 'none'

        let rep_why = $('input[name=rep_why]:checked').val();
        let description = $('#description').val();
        const postData = {
            rep_why: rep_why,
            description: description,    
        }
        console.log(postData);
        $.post("php/insert_reports.php",postData,function (response){
            console.log(response+"   "+postData['rep_why']);
        });
        e.preventDefault();
    });



});