<?php
//Variables for the connection
	$servername = "localhost";
	$server_username =  "id8297512_sarmad057";
	$server_password = "pakistan123";
	$dbName = "id8297512_dysspell";
	
	//Make Connection
	$conn = new mysqli($servername, $server_username, $server_password, $dbName);
	
	//chech that connection happened
	if(mysqli_connect_errno())
	{
		echo "1: Connection failed"; //error code #1 = connection failed
		exit();
	}
	$username = $_POST["name"];
	$score = $_POST["score"];
	$gamename = $_POST["gamename"];
	
	//double check there is only one user with this name
	$namecheckquery = "SELECT username FROM registered where username= '" . $username . "';";
	$namecheck = mysqli_query($conn, $namecheckquery) or die("2: Namecheck query failed");
	if(mysqli_num_rows($namecheck) != 1)
	{
		echo "5: Either no user with name, or more than one";
		exit();
	
	}
	$sql = "INSERT INTO scores1 (username, score, gamename)
			VALUES ('".$username."', '".$score."', '".$gamename."')";
	mysqli_query($conn ,$sql) or die("7: Save query failed");
	
	
	echo "0";
	?>