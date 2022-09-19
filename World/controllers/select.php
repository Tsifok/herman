<?php
require("includes/connection.php");

$sql_ls_country = "SELECT continent, name FROM country";
$sql_ls_country_validation = mysqli_query($conn, $sql_ls_country);

while ($ls_country = mysqli_fetch_assoc($sql_ls_country_validation)) {
    echo "<tr> <td>" . $ls_country['name'] . "</td> <td>" . $ls_country['continent'] . "</td> </tr>";
}
