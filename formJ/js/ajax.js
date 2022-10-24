$(function(){
    $('#report').submit(function (e){
        e.preventDefault();
        let rep_why = $("input:radio[name=rep_why]:checked").val();
        //let description = $("#description");
        document.getElementById('lol').style.display='none';
        const postData ={
            rep_why: rep_why,
            description: description,
        }
        $.post("php/insert.php",postData);
        
        //,function(result){ alert("la consulta esta echa se ha agregado "+result)}
    })
});



