<?php


$dbname = 'UnityDB';
$dbuser = 'camilo';
$dbpass = 'Noviembre2018';
$dbhost = 'localhost';

//conectarce al servidor mysql  (servidor,user,pasword,NombreBD)
$conect = new mysqli($dbhost, $dbuser, $dbpass,$dbname);


//recibe los datos de unity, usamos el valor de estas variables

$posX = array();
$px = $_REQUEST['PosX'];
$posY = array();
$py = $_REQUEST['PosY'];
$posZ = array();
$pz = $_REQUEST['PosZ'];
$time = array();
$tm = $_REQUEST['Time'];

$cedula = $_REQUEST['Cedula'];
$nombre = $_REQUEST['Nombre'];
$apellido = $_REQUEST['Apellido'];
$correo = $_REQUEST['Correo'];
$modulo = $_REQUEST['Modulo'];


//pregunto si el id de usuario ya esta en la tabla
$IDexistente = mysqli_query($conect, "SELECT * FROM Oversas WHERE Cedula='$cedula' ");


//se obtienen todos los datos del usuario idUser
while($row = mysqli_fetch_array($IDexistente))
{
	$nom = $row['Nombre'];
    $ape = $row['Apellido'];
    $cor = $row['Correo'];
    $ced = $row['Cedula'];
    $int = $row['Intento'];
    
    $posX = explode('_', $px);
	$posY = explode('_', $py);
	$posZ = explode('_', $pz);
	$time = explode('_', $tm);
	
}



//si no hay idSelect, significa que el usuario no existe
if($ced == null)
{

		$data1 = mysqli_query($conect, "SELECT MAX('ID') FROM Oversas");
	while($row = mysqli_fetch_array($data1))
	{
		$puesto = $row['MAX(ID)'];
	}
	//en el php le adiciono +1 al idSelect
	$primerIntento = 1;
	
	//insertar Valores en la base de datos Bonotes
	for($x = 0; $x < count($posX); $x++){
		$data1 = mysqli_query($conect, "SELECT MAX('ID') FROM Oversas");
        $adicionarDatos = mysqli_query($conect, "INSERT INTO 
        Oversas(Nombre,Apellido,Cedula,Correo,Modulo,Intento,Tiempo,PosX,PosY,PosZ) VALUES('$nombre','$apellido','$cedula','$correo','2','1','$time[$x]',$posX[$x],$posY[$x],$posZ[$x])");
    }

	echo $data1;
}
//si el id de usuario si esta en la tabla entonces cambie los valores 
else
{
		//en el php le adiciono +1 al btn1
        $data2 = mysqli_query($conect, "SELECT MAX('Intento') FROM Oversas WHERE Cedula = '$ced'");
		$variableIntento = $data2 + 1;
        
        for($x = 0; $x < count($posX); $x++){
        $adicionarDatos = mysqli_query($conect, "INSERT INTO 
        Oversas(Nombre,Apellido,Cedula,Correo,Modulo,Intento,Tiempo,PosX,PosY,PosZ) VALUES('$nombre','$apellido','$cedula','$correo','2','$variableIntento','$time[$x]',$posX[$x],$posY[$x],$posZ[$x])");
    
	}


	echo "cambiado";

}
?>

