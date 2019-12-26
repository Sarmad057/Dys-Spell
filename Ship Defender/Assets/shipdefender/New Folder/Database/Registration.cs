using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Registration : MonoBehaviour {

    public InputField nameField;
    public InputField passwordField;

    public Button submitButton;
    public Text prompt;
    public void CallRegister()
    {
        StartCoroutine(Register());
    }
    IEnumerator Register()
    {
        WWWForm  form = new WWWForm();
        form.AddField("username", nameField.text);
        form.AddField("password", passwordField.text);
        WWW www = new WWW("https://dysspell.000webhostapp.com/register.php", form);
        yield return www;
        if(www.text == "0")
        {
            Debug.Log("User Created successfully.");
            UnityEngine.SceneManagement.SceneManager.LoadScene("menubysarmad");
        }
        else
        {
            Debug.Log("User creation failed. Error #" + www.text);
            prompt.text = "Already Registered";
        }

    }
    public void Back()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("menubysarmad");
    }

    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 4 && passwordField.text.Length >=4);
    }
    
}
