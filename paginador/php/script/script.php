<?php
require_once "../setting.php";
//require_once("setting.php");
$str = '0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ';

// str_shuffle($str);

mysqli_report(MYSQLI_REPORT_ERROR | MYSQLI_REPORT_STRICT); // muestra excepciones (parecido a un error, pero el programa sigue ejecutando) 
mysqli_begin_transaction($conn); // query el cual no debe fallar y es un insert grande
try { // intenta esto
    for ($i = 0; $i <= 1000; $i++) {
        $insert = "INSERT INTO mil_registros(content) VALUES('" . str_shuffle($str) . "')";
        $query = mysqli_real_query($conn, $insert);
    }
    mysqli_commit($conn);
} catch (mysqli_sql_exception $e) { // si el try falla sucede esto
    mysqli_rollback($conn);
    die("fallo");
}
