<?php

namespace App;

require_once("DatabaseConnector.php");

class DataComparer
{
    private $username;
    private $password;
    private $dbc;

    function __Construct($username, $password)
    {
        $this->dbc = Connect();
        $this->username = $username;
        $this->password = $password;
    }

    function Compare()
    {
        $stmt = $this->dbc->prepare("SELECT * FROM users WHERE username=:username LIMIT 1");
        $stmt->execute(array(':username'=>$this->username));
        $userRow=$stmt->fetch(\PDO::FETCH_ASSOC);
        if($stmt->rowCount() > 0)
        {
            if(password_verify($this->password, $userRow['password']))
            {
                return "Succesfully logged in.";
            }
            else
            {
                return "Password is incorrect.";
            }
        }
        else
        {
            return "username not found.";
        }
    }
}
?>