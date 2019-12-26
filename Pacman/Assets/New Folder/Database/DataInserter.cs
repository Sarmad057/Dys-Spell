using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataInserter : MonoBehaviour {

	public string inputUserName;
	public string inputPassword;
	public string inputscore;

    //string CreateUserURL = "http://localhost/DysSpell/insert_score.php";

    // Use this for initialization

    // Update is called once per frame
    public void Insert () {
            
            CreateUser(inputUserName, inputPassword, inputscore);
        
	}

	public void CreateUser(string username, string password, string score){
		WWWForm form = new WWWForm();
		form.AddField("usernamePost", username);
		form.AddField("passwordPost", password);
		form.AddField("scorePost", score);

		//WWW www = new WWW(CreateUserURL, form);
        //Count();
        print(PlayerPrefs.GetString("rows"));
	}
   /* IEnumerator Count()
    {
        WWW noofrows = new WWW("http://localhost/DysSpell/insert_score.php");
        yield return noofrows;
        string count = noofrows.text;
        print(count);
    }
    */
}
