<?php
namespace App;
session_start();
require_once("DataComparer.php");

if ($_SERVER['REQUEST_METHOD'] == 'GET')
{
    session_destroy();
    header("location: ../public/index.php");
}

$username = $_POST["username"];
$password = $_POST["password"];
$DataComparer = new DataComparer($username, $password);
$DataComparer->Compare();

header("location: ../public/index.php")
?>