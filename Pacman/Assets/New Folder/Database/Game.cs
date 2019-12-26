using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Game : MonoBehaviour {

    // Use this for initialization
    public Text playerDisplay;
    //public Text scoreDisplay;
    public int score1;
    // for zebra end
    void OnTriggerEnter()
    {

        StartCoroutine(SavePlayerData());
    }
    private void Awake()
    {
        if(DBManager.username == null)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("menubysarmad");
        }
        //DBManager.score = DBManager.score + PlayerPrefs.GetInt("score");
        //DBManager.score = int.Parse(scoreText.text);
        //DBManager.score = player;
        //scoreDisplay.text = "Score: " + DBManager.score;
        playerDisplay.text =  DBManager.username;
        //scoreDisplay.text = "Score: " + score1;
    }
    public void CallSaveData()
    {
        StartCoroutine(SavePlayerData());
    }
    IEnumerator SavePlayerData()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", DBManager.username);
        //print("checking1");
        print(score1);
        form.AddField("score",+score1);
        form.AddField("gamename", "pacman");

        WWW www = new WWW("https://dysspell.000webhostapp.com/savascore.php", form);
        yield return www;
        if(www.text == "0")
        {
            Debug.Log("Game Saved.");
            UnityEngine.SceneManagement.SceneManager.LoadScene("menubysarmad");
        }
        else
        {
            Debug.Log("Save failed. Error #" + www.text);
            UnityEngine.SceneManagement.SceneManager.LoadScene("menubysarmad");
        }

        //DBManager.LogOut();
        //PlayerPrefs.SetInt("score", 0);
        //PlayerPrefs.SetInt("endscore", 0);
        //UnityEngine.SceneManagement.SceneManager.LoadScene("menubysarmad");
    }
    /*public void IncreaseScore()
    {
        //DBManager.score = DBManager.score + PlayerPrefs.GetInt("score");
        //DBManager.score = int.Parse(scoreText.text);
        //DBManager.score = player;
        scoreDisplay.text = "Score: " + DBManager.score;
    }*/
    void Update()
    {

        //score1 = PlayerPrefs.GetInt("endscore") + PlayerPrefs.GetInt("score");

        score1 = GameManager.score;
        print(GameManager.score);

        //DBManager.score = int.Parse(scoreText.text);
        //DBManager.score = player;
        //scoreDisplay.text = "Score: " + DBManager.score;
        //playerDisplay.text = "Player: " + DBManager.username;
        //print("checking2");
        //print(DBManager.score);
        //PlayerPrefs.SetInt("score1", score1);
        //scoreDisplay.text = "Score: " + score1;
    }
}
