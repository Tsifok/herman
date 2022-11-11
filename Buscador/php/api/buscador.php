<?php

require_once "../controllers/conexion.php";

$select = "SELECT * FROM mil_registros WHERE content LIKE '%".$_POST['content']."%' ";

$result = mysqli_query($conn,$select);

if(!$result){
    echo json_encode($result);
}