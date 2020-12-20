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
            add_guitar();
            break;

        case 'PUT':
            update_guitar();
            break;

        case 'DELETE':
            $id=intval($_GET["id"]);
            delete_guitar($id);
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
    function add_guitar(){
        global $conn;
        $data = json_decode(file_get_contents('php://input'), true);
        $gitar_marka = $data["Marka"];
        $gitar_forma = $data["Forma"];
        $gitar_bundok = $data["Bundok"];
        $gitar_hangszedo = $data["Hangszedo"];
        $gitar_hurok = $data["Hurok"];
        $gitar_tipus = $data["Tipus"];

        $query="INSERT INTO gitar SET 
        marka = '$gitar_marka',
        forma = '$gitar_forma',
        bundok = '$gitar_bundok',
        hangszedo = '$gitar_hangszedo',
        hurok = '$gitar_hurok',
        tipus = '$gitar_tipus'";

        if(mysqli_query($conn, $query))
        {
           $response=array(
                 'status' => 1,
                 'status_message' =>'Gitar hozzaadva.'
                  );
        }
        else
        {
           $response=array(
                 'status' => 0,
                 'status_message' =>'Hozzaadas fail.'
                 );
        }
        header('Content-Type: application/json');
        echo json_encode($response); //response with header 
    }
    function update_guitar(){
        global $conn;
        $data = json_decode(file_get_contents('php://input'), true);
        $gitar_marka = $data["Marka"];
        $gitar_forma = $data["Forma"];
        $gitar_bundok = $data["Bundok"];
        $gitar_hangszedo = $data["Hangszedo"];
        $gitar_hurok = $data["Hurok"];
        $gitar_tipus = $data["Tipus"];
        $gitar_id = $data["Id"];

        $query="UPDATE gitar SET 
        marka = '$gitar_marka',
        forma = '$gitar_forma',
        bundok = '$gitar_bundok',
        hangszedo = '$gitar_hangszedo',
        hurok = '$gitar_hurok',
        tipus = '$gitar_tipus'
        WHERE id =".$gitar_id;
        if(mysqli_query($conn, $query))
        {
        $response=array(
                'status' => 1,
                'status_message' =>'Gitar modositva.'
                );
        }
        else
        {
        $response=array(
                'status' => 0,
                'status_message' =>'Modositas sikertelen.'
                );
        }
        header('Content-Type: application/json');
        echo json_encode($response); //response with header 
    }
    function delete_guitar($id){
        global $conn;
        $query = "DELETE FROM gitar WHERE id=".$id;
        if(mysqli_query($conn, $query))
        {
            $response=array(
            'status' => 1,
            'status_message' =>'Sikeres torles.'
            );
        }
        else
        {
            $response=array(
                'status' => 0,
                'status_message' =>'Torles hiba.'
            );
        }
        header('Content-Type: application/json');
        echo json_encode($response);
    }

?>