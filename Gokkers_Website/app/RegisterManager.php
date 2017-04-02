<?php
namespace App;

require_once("DataSender.php");

if (filter_var($_POST["email"], FILTER_VALIDATE_EMAIL))
{
    session_start();
    $username = $_POST["username"];
    $email = $_POST["email"];
    $password = $_POST["password"];
    $confirmPassword = $_POST["confirmPassword"];
    $sender = new DataSender($username, $email, $password, $confirmPassword);
    $message = $sender->Send();
    if ($message != false)
    {
        $_SESSION["reg_error"] = $message;
    }
    else
    {
        $message = "Succesfully registered";
        $_SESSION["reg_succes"] = $message;
    }
}
else
{
    $message = "Something went wrong, please try again.";
    $_SESSION["reg_error"] = $message;
}
header("location: ../public/index.php");