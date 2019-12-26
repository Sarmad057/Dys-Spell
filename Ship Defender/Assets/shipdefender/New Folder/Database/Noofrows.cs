using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Noofrows : MonoBehaviour {

	IEnumerator Start()
    {
        WWW noofrows = new WWW("http://localhost/DysSpell/norowsscore.php");
        yield return noofrows;
        string count = noofrows.text; 
        print(count);
        PlayerPrefs.SetString("rows", count);
    }
    public void Callstart()
    {
        StartCoroutine(Start());
    }
}
