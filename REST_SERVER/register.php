<?php 

    include("connection.php");
    $db = new DatabaseObject();
    $conn = $db->getConnString();
    $kuldott_keres = $_SERVER["REQUEST_METHOD"];

    if ($kuldott_keres == 'POST') {
        $data = json_decode(file_get_contents('php://input'),true);
    
        $username = $data["UserName"];
        $password = md5($data["Password"]);

        $checkQuery = "SELECT username FROM users";
        $checkFailed = false;
        $result = mysqli_query($conn,$checkQuery);

        while ($row = mysqli_fetch_array($result)) {
            if ($row['username'] == $username) {
                $checkFailed = true;
            } 
        }
        if ($checkFailed) {
            $response=array(
                'status' => 0,
                'status_message' => 'Foglalt username.'
            );
        }else{
            $query = "INSERT INTO users SET username='$username', password ='$password'";
            
            if (mysqli_query($conn, $query)) {
                $response=array(
                    'status' => 1,
                    'status_message' => 'Sikeres regisztracio.'
                );
            }
            else{
                $response=array(
                    'status' => 0,
                    'status_message' => 'Sikertelen regisztracio.'
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