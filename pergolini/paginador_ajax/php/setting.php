<?php 

$conn_data = array(
    "host" => "localhost", 
    "user" => "root",
    "password" => "",
    "bd_name" => "escuela"
);

//print_r($conn_data);
//mysqli_report(MYSQLI_REPORT_ALL);

$conn  = mysqli_connect($conn_data['host'],$conn_data['user'],$conn_data['password'],$conn_data['bd_name']);

if(!$conn){
    die("A fatal error ocurred while attemping to connect to mysql service ".mysqli_connect_error());
}
?>