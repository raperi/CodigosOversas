<?php

$dbname = 'UnityDB';
$dbuser = 'camilo';
$dbpass = 'Noviembre2018';
$dbhost = 'localhost';

$conect = new mysqli($dbhost, $dbuser, $dbpass,$dbname);

$userNombre = $_REQUEST['Nombre'];
$userIntento = $_REQUEST['Intento'];
$lista = array();
$result = "";


$consulta = mysqli_query($conect, "SELECT PosY FROM Oversas WHERE Nombre ='$userNombre' AND Intento = '$userIntento'");

while($item= mysqli_fetch_array($consulta))
{
    $lista[] = $item;
}

for($x = 0; $x < sizeof($lista); $x++){
	$result = $result . $lista[$x] . "-";
}
echo $result;

?>