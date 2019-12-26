using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class BarChart : MonoBehaviour {

    public string[] items;

    //public Text playerDisplay1;
    //public Text gamename1;


    public Bar barPrefab;
    public int[] inputValues;
    public string[] labels;
    public Color[] colors;
    //List<Bar> bars = new List<Bar>();
    float chartHeight;
    public Text playerDisplay1;
    public Text gamename2;
    //public Text scoreDisplay;
    //public int score1;


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
        playerDisplay1.text = DBManager.username;
        //scoreDisplay.text = "Score: " + score1;
        gamename2.text = "Ship Defender";
    }
    void Start () {
        chartHeight = Screen.height + GetComponent<RectTransform>().sizeDelta.y;
        //var instance = new DataLoader();
        //instance.CallGetScore();
        StartCoroutine(Getscore());
        //print(PlayerPrefs.GetInt("scorearrlength"));

        /*for (int i = 0; i < (PlayerPrefs.GetInt("scorearrlength")); i++)
        {
            inputValues[i] = (PlayerPrefs.GetInt("scorearray" + i));
            print(PlayerPrefs.GetInt("scorearray" + i));
        }*/
        /*for (int i = 0; i < 5; i++)
        {
            print(inputValues[i]);
        }*/

        //print(inputValues.Length);

        //DisplayGraph(inputValues);
	}
    void DisplayGraph(int[] vals)
    {
        int maxvalue = vals.Max();
        for (int i =0; i<vals.Length; i++)
        {
            Bar newBar = Instantiate(barPrefab) as Bar;
            newBar.transform.SetParent(transform);
            //size bar
            RectTransform rt = newBar.bar.GetComponent<RectTransform>();
            float normalizedvalue = ((float)vals[i]/(float)maxvalue) * 0.95f;
            rt.sizeDelta = new Vector2(rt.sizeDelta.x, chartHeight * normalizedvalue);
            newBar.bar.color = colors[i % colors.Length];
            //set label
            //if (labels.Length <= i)
            //{
            //    newBar.label.text = "UNDEFINED";
            //}
            //else
            //{
            //newBar.label.text = labels[i]
            newBar.label.text = (i+1).ToString();
            //}
            newBar.barValue.text = vals[i].ToString();
            //if height is too small, move label to top of bar
            if(rt.sizeDelta.y < 30f)
            {
                newBar.barValue.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0f);

                newBar.barValue.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
            }
        }
        
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
            PlayerPrefs.SetInt("scorearrlength", items.Length - 1);
            inputValues = new int[items.Length - 1];
            
            for (int i = 0; i < items.Length - 1; i++)
            {
                //PlayerPrefs.GetInt("scorearray" + i);
                //print(GetDataValue(items[i], "Score:"));
                inputValues[i] = int.Parse(GetDataValue(items[i], "Score:"));
                //print(inputValues[i]);
                 //PlayerPrefs.SetInt("Scorearray" + i, int.Parse(GetDataValue(items[i], "Score:")));

            }
            DisplayGraph(inputValues);

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
    /*private void Awake()
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
    }*/


    public void GotoMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("menubysarmad");
    }
}




