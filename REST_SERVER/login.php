<?php 

    include("connection.php");
    $db = new DatabaseObject();
    $conn = $db->getConnString();
    $kuldott_keres = $_SERVER["REQUEST_METHOD"];

    if ($kuldott_keres == 'POST') {
        $data = json_decode(file_get_contents('php://input'),true);
    
        $username = $data["UserName"];
        $password = md5($data["Password"]);

        $db_password = "";

        $query = "SELECT password FROM users WHERE username='$username'";
        $result = mysqli_query($conn, $query);


        if (mysqli_num_rows($result) == 0) {
            $response=array(
                'status' => 0,
                'status_message' => 'Nincs ilyen felhasznalo'
            );
        }
        else{
            while ($row = mysqli_fetch_assoc($result)) {
                $db_password = $row['password'];
            }
            if ($db_password != $password) {
                $response=array(
                    'status' => 0,
                    'status_message' => 'Hibas jelszo.'
                );
            }else{
                $response=array(
                    'status' => 1,
                    'status_message' => 'Sikeres belepes'
                );
            }
        }            
        header('Content-Type: application/json');
        echo json_encode($response);
    }
    else{
        header("HTTP/1.0 405 Method Not Allowed");
    }
    
?>