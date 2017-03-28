<?php
namespace App;

require_once("DatabaseConnector.php");
require_once("../config/databaseConfig.php");

class DataValidator
{
    private $errorMessage;

    public function Validate($email, $username, $password, $confirmPassword, $dbc)
    {
        $errors=array();
        if (!preg_match('/^[A-Za-z0-9#,.\-_]*$/', $password))
            $errors[] = 'Invalid characters used in password.';
        if (strlen($password) < 7)
            $errors[] = 'Password not long enough';
        if (strlen(preg_replace('/[^0-9]/','',$password)) < 1)
            $errors[] = 'No number found in password.';
        if (strlen(preg_replace('/[^A-Z]/','',$password)) < 1)
            $errors[] = 'No capital letter found in password.';

        if (count($errors) > 0) //Didn't work
        {
           return $errors;
        }

        if
         ($password == $confirmPassword)
        {
            $sql = $dbc->prepare("SELECT COUNT(*) AS `total` FROM `tbl_users` WHERE `username` = `:username`");
            $sql->execute([':username' => $username]);
            $result = $sql->fetchAll();

            if ($result[0]['total'] > 0)
            {
                $errorMessage = "Username is already in use.";
                return $errorMessage;
            }

            $sql = $dbc->prepare("SELECT COUNT(*) AS `total` FROM `tbl_users` WHERE `email` = `:email`");
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