<?php

Class DatabaseObject{

    var $db_user = "root";
    var $db_pass = "";
    var $db_dbname = "rest_guitars";
    var $db_host = "localhost";
    var $conn;

    function getConnString(){
        $con = mysqli_connect($this->db_host, $this->db_user, $this->db_pass, $this->db_dbname) or 
            die("Connection failed: " . mysqli_connect_error());

        if (mysqli_connect_errno()) {
            prinf("Kapcsolati hiba: \n", mysqli_connect_error());
            exit();
        }
        else{
            $this->conn = $con;
        }
        return $this->conn;
    }
}
    
?>