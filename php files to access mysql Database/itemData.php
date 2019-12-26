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
	$gamename = $_POST["gamename"];
	
	//double check there is only one user with this name
	/*$namecheckquery = "SELECT username FROM scores where username= '" . $username . "';";
	$namecheck = mysqli_query($conn, $namecheckquery) or die("2: Namecheck query failed");
	if(mysqli_num_rows($namecheck) < 1)
	{
		echo "5: Either no user with name, or more than one";
		exit();
	
	}*/
	$sql = "SELECT id, username, score FROM scores1 where username= '" . $username . "'   AND  gamename= '" . $gamename . "'       ;";
	$result = mysqli_query($conn, $sql) or die("2: Namecheck query failed");
	if(mysqli_num_rows($result) < 1)
	{
		echo "5: Either no user with name, or more than one";
		exit();
	
	}
	if(mysqli_num_rows($result)>0){
		//show data for each row
		while($row = mysqli_fetch_assoc($result)){
			echo "ID:".$row['id'] . "|Name:".$row['username']. "|Score:".$row['score'] . ";";
		}
	}
	
	
	
	