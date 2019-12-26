using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataLoader : MonoBehaviour {
    public string[] items;

    //public Text playerDisplay1;
    //public Text gamename1;
    private void Awake()
    {
        if (DBManager.username == null)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("menubysarmad");
        }
        //DBManager.score = DBManager.score + PlayerPrefs.GetInt("score");
        //DBManager.score = int.Parse(scoreText.text);
        //DBManager.score = player;
        //scoreDisplay.text = "Score: " + DBManager.score;
        
        //playerDisplay1.text = DBManager.username;
        //gamename1.text = "Ship Defender";
    }
    public void CallGetScore()
    {
       StartCoroutine(Getscore());
    }
    IEnumerator Getscore()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", DBManager.username);
        form.AddField("gamename", "shipdefender");

        WWW www = new WWW("https://dysspell.000webhostapp.com/itemData.php", form);
        yield return www;


        
        string itemsDataString = www.text;
        
        if (www.text != "1: Connection failed" && www.text != "5: Either no user with name, or more than one" && www.text != "2: Name check query failed")
        {
            items = itemsDataString.Split(';');
            //PlayerPrefs.SetInt("scorearrlength", items.Length - 1);
            for (int i = 0; i < items.Length-1; i++)
            {
                //PlayerPrefs.GetInt("scorearray" + i);
                print(GetDataValue(items[i], "Score:"));
               // PlayerPrefs.SetInt("Scorearray" + i, int.Parse(GetDataValue(items[i], "Score:")));

            }
        }
        else
        {
            
            Debug.Log("Error #" + www.text);
        }

        //DBManager.LogOut();
        //PlayerPrefs.SetInt("score", 0);
        //PlayerPrefs.SetInt("endscore", 0);
        //UnityEngine.SceneManagement.SceneManager.LoadScene("menubysarmad");




        /*items = itemsDataString.Split(';');

        for(int i=0; i<5; i++)
        {
            print(GetDataValue(items[i], "Score:"));
        }*/
        //DBManager.LogOut();
        //UnityEngine.SceneManagement.SceneManager.LoadScene("menubysarmad");
    }

	string GetDataValue(string data, string index)
    {
        string value = data.Substring(data.IndexOf(index) + index.Length);
        if (value.Contains("|")) value.Remove(value.IndexOf("|"));
        return value;
        
    }
}
