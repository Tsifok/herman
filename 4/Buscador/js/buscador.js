$( document ).ready(function() {
    
    var code_html="";

    $.ajax({
        url: 'php/api/buscador.php',
        type: 'POST',
        dataType: 'JSON',
        success: function (data) {
            data.forEach(function(element) {
                code_html += `<option value="${element.id}">${element.content}</option>`;
            });      
            $('.busqueda').append(code_html);
            $('.busqueda').select2({
                 minimumInputLength: 3
             });
        }
    });

});