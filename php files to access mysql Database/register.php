<?php
//Variables for the connection
	$servername = "localhost";
	$server_username =  "id8297512_sarmad057";
	$server_password = "pakistan123";
	$dbName = "id8297512_dysspell";
	
	//Make Connection
	$conn = new mysqli($servername, $server_username, $server_password, $dbName);
	//check that connection happenend
	if(mysqli_connect_errno())
	{
		echo "1: Connection failed";
		exit();
	}
	$username =$_POST["username"];
	$password =$_POST["password"];
	
	//check if name exists
	$namecheckquery = "SELECT username FROM registered WHERE username='" . $username . "';";
	$namecheck = mysqli_query($conn, $namecheckquery) or die("2: Name check query failed");
	if(mysqli_num_rows($namecheck) > 0){
		echo "3: Name already exists";
		exit();
	}
	// add user to the table
	
	$insertuserquery = "INSERT INTO registered (username, password) VALUES('" . $username . "', '" . $password ."');";
	mysqli_query($conn, $insertuserquery) or die("4: Insert player query failed");
	echo "0";
?>