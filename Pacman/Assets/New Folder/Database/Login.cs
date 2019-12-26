using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour {
    public Text prompt1;
    public InputField nameField;
    public InputField passwordField;

    public Button submitButton;
    public void CallLogin()
    {
        StartCoroutine(LogIn());
    } 
    IEnumerator LogIn()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", nameField.text);
        form.AddField("password", passwordField.text);
        WWW www = new WWW("https://dysspell.000webhostapp.com/login.php", form);
        yield return www;
        if (www.text[0] == '0')
        {
            DBManager.username = nameField.text;
            //DBManager.score = int.Parse(www.text.Split('\t')[1]);
            UnityEngine.SceneManagement.SceneManager.LoadScene("menubysarmad");
            //DataLoader instance = new DataLoader();
            //instance.CallGetScore();
        }
        else
        {
            Debug.Log("User login failed. Error#" + www.text);
            prompt1.text = "Name isn't registered";
        }
    }
    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 4 && passwordField.text.Length >= 4);
    }
    public void Back1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("menubysarmad");
    }
}
