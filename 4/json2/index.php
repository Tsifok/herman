<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <script src="js/jquery.js"></script>
    <script src="js/ajax.js"></script>
    <title>Ajax2</title>
</head>
<body>
    <form action="php/insertar.php?" method="GET" id="frmajax">
        <input type="text" name="nom_materia" placeholder="Nombre de materia">
        <input type="text" name="otro" placeholder="OTRO">
        <input type="submit" value="Enviar" id="submit">
    </form>
</body>
</html>