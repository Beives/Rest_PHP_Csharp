<?php 

    include("connection.php");
    $db = new DatabaseObject();
    $conn = $db->getConnString();
    $kuldott_keres = $_SERVER["REQUEST_METHOD"];
    
    switch($kuldott_keres){
        case 'GET':
            if (!empty($_GET['id'])) {
                $id=intval($_GET["id"]);
                get_guitar_by_id($id);
            }
            else{
                get_guitars();
            }
            break;

        case 'POST':
            post_dummy();
            break;

        case 'PUT':
            put_dummy();
            break;

        case 'DELETE':
            delete_dummy();
            break;

        default:
            header('HTTP 405 Method not allowed');
            break;
    }

    function get_guitars(){
        global $conn;
        $query="SELECT * FROM gitar";
        $response=array();
        $result = mysqli_query($conn,$query);
        while($row = mysqli_fetch_array($result)){
            $response[]=$row;
        }
        header('Content-Type: application/json');
        echo json_encode($response);
    }

    function get_guitar_by_id($id){
        global $conn;
        $query="SELECT * FROM gitar WHERE id=".$id;
        $response=array();
        $result = mysqli_query($conn, $query);
        $response[] = mysqli_fetch_array($result);
        header('Content-Type: application/json');
        echo json_encode($response);
    }
    function put_dummy(){
        
    }
    function delete_dummy(){
        
    }

?>