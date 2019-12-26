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
	$namecheckquery = "SELECT username, password FROM registered WHERE username='" . $username . "';";
	$namecheck = mysqli_query($conn, $namecheckquery) or die("2: Name check query failed");
	if(mysqli_num_rows($namecheck)!=1)
	{
		echo "5: Either no user with name, or more than one";
		exit();
	}
	// get login info from query
	$existinginfo = mysqli_fetch_assoc($namecheck);
	if($existinginfo["password"]!=$password){
		echo "6: Incorrect password";
		exit();
	}
	echo "0\t";
?>