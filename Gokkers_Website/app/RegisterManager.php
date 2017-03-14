<?php
namespace App;

require("DataSender.php");

$username = $_GET["username"];
$email = $_GET["email"];
$password = $_GET["password"];
$confirmPassword = $_GET["confirmPassword"];


$sender = new DataSender($username, $email, $password, $confirmPassword);

$sender->Send();