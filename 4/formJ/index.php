<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <script src="js/jQuery.js"></script>
    <title>Document</title>
</head>

<body>
    
    <div id="lol">
        <form id="report" method="POST">
            <input type="radio" name="rep_why" value="inf_err">
            <label for="inf_err">inf_err</label><br>
            <input type="radio" name="rep_why" value="cont_ofens">
            <label for="cont_ofens">cont_ofens</label><br>
            <textarea name="description" id="description" cols="30" rows="10" class="modal_form_textarea" placeholder="Agregar descripcion especifica de la infraccion" maxlength="500"></textarea><br>
            <button id="rep_submit">Enviar
        </form>
    </div>

    <script src="js/ajax.js"></script>
    <div id="respuesta"></div>
    
</body>
</html>