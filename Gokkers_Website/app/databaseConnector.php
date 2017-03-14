<?php
namespace App;

include ("../config/databaseConfig.php");
function Connect()
{
    $dbc = @mysqli_connect(DB_HOST,DB_USER,DB_PASSWORD,DB_NAME) or die("unable to connect to the database");

    return $dbc;
}
?>