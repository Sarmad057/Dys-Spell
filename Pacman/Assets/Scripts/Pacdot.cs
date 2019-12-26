using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Pacdot : MonoBehaviour
{
    public static int im = 0;
    public void resetim()
    {
        im = 0;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "pacman")
        {
            GameObject[] pacdots = GameObject.FindGameObjectsWithTag("pacdot");
            print(pacdots.Length);
            print(SceneManager.GetActiveScene().name);
            if (gameObject.name[0] == SceneManager.GetActiveScene().name[im])
            {
                Destroy(gameObject);
                GameManager.score += 10;
                im++;
                if (im == SceneManager.GetActiveScene().name.Length)
                {
                    im = 0;
                }
            }
            else
            {
                print(SceneManager.GetActiveScene().name[im]);
                if (GameManager.score >= 5)
                {
                    GameManager.score -= 5;
                }
            }
            if (pacdots.Length == 1)
            {
                if (SceneManager.GetActiveScene().name != "Zebra")
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    GameObject.FindObjectOfType<GameGUINavigation>().LoadLevel();
                }
                
            }
        }
    }
}

