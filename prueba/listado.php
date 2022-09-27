<?php
$direction = "localhost";
$user = "root";
$password = "";
$name_bd = "escuela";


$conn = mysqli_connect($direction,$user,$password,$name_bd);

if(!$conn){
    die('Fatal error to connect bd'.mysqli_connect_error());
}

$sql_select = "SELECT * FROM materias";
$sql_row = mysqli_query($conn,$sql_select);

if(!$sql_row){
    die('Fatal error to query'.mysqli_error($conn));
}
?>    
    <table border="1">
<?php
    while($rows = mysqli_fetch_assoc($sql_row)){
        echo "<tr><td>".$rows['id']."</td><td>".$rows['name']."</td><tr>";
    }
?>
    </table>