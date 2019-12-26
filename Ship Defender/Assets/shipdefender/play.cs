using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Play : MonoBehaviour {

	// Use this for initialization
	public void Start1() {
        SceneManager.LoadScene("Apple");
    }
	public void Exit()
    {
        Application.Quit();
    }
}
