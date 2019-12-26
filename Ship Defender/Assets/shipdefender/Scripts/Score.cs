using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    public int[][] scores;
    //public float s=0;
    //public Text highscore;
    //public int number;

    // Update is called once per frame
    void Update()
    {
        //highscore.text=PlayerPrefs.GetInt("HighScore", 0).ToString();
        //s =  player.position.z;
        scoreText.text = player.position.z.ToString("0");
        

        PlayerPrefs.SetInt("score", int.Parse(scoreText.text));
        //DBManager.score = PlayerPrefs.GetInt("score");
        //print(PlayerPrefs.GetInt("score"));
        //scoreText.text = s.ToString("0");

        // int a =  System.Convert.ToInt32(scoreText.text);
        //if (a> PlayerPrefs.GetInt("HighScore", 0))
        //{

        //highscore = a;
        //print("HighScore="+highscore);
        //int.TryParse(highscore.text, out number);
        //PlayerPrefs.SetInt("HighScore", number);
        // highscore.text = number.ToString();
        // print("HighScore=" + highscore);
        // }
        //int.TryParse(scoreText.text, out number);
        //print("a is"+a);
        //print("b is" + number);
        //PlayerPrefs.SetInt("sarmad", 40);
        //print(PlayerPrefs.GetInt("sarmad").ToString());

    }   
   // public void record()
   // {
   //     PlayerPrefs.SetInt("sarmad", 40);
   //     print(PlayerPrefs.GetInt("sarmad").ToString());
   // }

}
