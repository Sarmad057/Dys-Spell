using UnityEngine;
using UnityEngine.SceneManagement;

//using System.Collections;
public class LevelComplete : MonoBehaviour {
    public Transform player;
    public void LoadNextLevel ()
	{
        //print(player.position.z);

        PlayerPrefs.SetInt("endscore", PlayerPrefs.GetInt("score")* (SceneManager.GetActiveScene().buildIndex));
        //print(PlayerPrefs.GetInt("score1"));

        /*if (SceneManager.GetActiveScene().name == "Zebra")
        {
            SceneManager.LoadScene("menubysarmad");
        }
        else
        {*/
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //}
        
	}

}
