<?php
namespace App;

require_once ("../config/databaseConfig.php");

function Connect()
{
    $dbc = new \PDO("mysql:host=".DB_HOST.";dbname=".DB_NAME, DB_USER, DB_PASSWORD);

    return $dbc;
}
?>