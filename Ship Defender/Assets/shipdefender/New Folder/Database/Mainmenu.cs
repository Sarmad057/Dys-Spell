using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Mainmenu : MonoBehaviour {
    public Text playerDisplay;
    public Button registerButton;
    public Button loginButton;
    public Button playButton;
    public Button logoutButton;
    public Button AnalysisButton;
    private void Start()
    {
        if (DBManager.LoggedIn)
        {
            playerDisplay.text = "Player: " + DBManager.username;
            PlayerPrefs.SetInt("score", 0);
            PlayerPrefs.SetInt("endscore", 0);
            
        }
        registerButton.interactable = !DBManager.LoggedIn;
        loginButton.interactable = !DBManager.LoggedIn;
        playButton.interactable = DBManager.LoggedIn;

        logoutButton.interactable = DBManager.LoggedIn;
        AnalysisButton.interactable = DBManager.LoggedIn;
    }

    public void GotoRegister()
    {
        SceneManager.LoadScene("registermenu");
    }
    public void GotoLoginMenu()
    {
        SceneManager.LoadScene("loginmenu");

    }
    public void GotoMainMenu()
    {
        SceneManager.LoadScene("menubysarmad"); 
    }
    public void GotoAnalysis()
    {
        SceneManager.LoadScene("Analysis");
    }
    public void Start1()
    {
        SceneManager.LoadScene("Apple");
    }
    public void LogOut()
    {
        DBManager.LogOut();
        SceneManager.LoadScene("menubysarmad");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
