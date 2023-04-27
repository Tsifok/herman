<?php

$conn_d = array(
    "host" => "localhost",
    "password" => "",
    "user" => "root",
    "db" => "escuela"
);

$conn = mysqli_connect($conn_d['host'],$conn_d['user'],$conn_d['password'],$conn_d['db']);

if(!$conn){
    
    die('Error de Conexión (' . mysqli_connect_errno() . ') '. mysqli_connect_error());
}