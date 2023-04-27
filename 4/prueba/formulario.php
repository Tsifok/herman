<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form action="alta.php" method="POST">
        <input type="text" name="materia" placeholder="Nombre materia" pattern="[a-zA-z]">
        <input type="submit" value="submit">
    </form>

    <?php 
    //falta añadir caracteres especiales

        if(isset($_GET['err'])){

            switch ($_GET['err']){
                case "1":
                    echo "<script>alert('El nombre ingresado ya esta en uso')</script>";
                break;
                case "0":
                    echo "<script>alert('El nombre ingresado ha sido exitosamente ingresado a la base de datos')</script>";
                break;
                case "2":
                    echo "<script>alert('El campo debe ser rellenado')</script>";
                break;
            }
                
            
        }
    
    ?>

</body>
</html>