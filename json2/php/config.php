<?php

    $host ="localhost";
    $user ="root";
    $password ="";
    $bd ="escuela";

    $conn = mysqli_connect($host,$user,$password,$bd);

    if(!$conn){
        die("Error al conectarse a la bd : ".mysqli_connect_error());
    }

?>