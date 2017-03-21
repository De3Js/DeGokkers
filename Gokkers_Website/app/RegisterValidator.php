<?php

namespace App;

require_once("DatabaseConnector.php");
require_once ("../config/databaseConfig.php");


class DataValidator
{
    public $errorMessage;
    public function Validate($email, $username, $password, $confirmPassword, $dbc)
    {
        if ($password == $confirmPassword)
        {
            $sql = $dbc->prepare("SELECT COUNT(*) AS `total` FROM tbl_users WHERE username = :username");
            $sql->execute([':username' => $username]);
            $result = $sql->fetchAll();

            if ($result[0]['total'] > 0)
            {
                $errorMessage = "Username is already in use.";
                return $errorMessage;
            }

            $sql = $dbc->prepare("SELECT COUNT(*) AS `total` FROM tbl_users WHERE email = :email");
            $sql->execute([':email' => $email]);
            $result = $sql->fetchAll();

            if ($result[0]['total'] > 0)
            {
                $errorMessage = "Email is already in use.";
                return $errorMessage;
            }

            $errorMessage = "Succesfully Registered";
            return $errorMessage;
        }
        else
        {
            return $this->errorMessage = "Passwords don't match.";
        }
    }
}