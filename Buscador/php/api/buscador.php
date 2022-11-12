<?php

require_once "../controllers/conexion.php";

    $i = 0;
    $select = "SELECT * FROM mil_registros LIMIT 0,10 ";

    $result = mysqli_query($conn,$select);

    if(!$result){
        die('Error de Consulta' . mysqli_error($conn));
    }

    while($res = mysqli_fetch_assoc($result)){
        $message[$i] = $res;
        $i++;
    }
    
    return print_r(json_encode($message));

