using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyRoomControlScript : MonoBehaviour {

	// References to trophies game objects to control
	public GameObject cup1, cup2, cup3, cup4, cup5, cup6, cup7, cup8, cup9, cup10, cup11, cup12, cup13, cup14, cup15, cup16, cup17, cup18, cup19, cup20, cup21, cup22, cup23, cup24, cup25, cup26;

	// Variables to contain Player Prefs values
	int cup1Got, cup2Got, cup3Got, cup4Got, cup5Got, cup6Got, cup7Got, cup8Got, cup9Got, cup10Got, cup11Got, cup12Got, cup13Got, cup14Got, cup15Got, cup16Got, cup17Got, cup18Got, cup19Got, cup20Got, cup21Got, cup22Got, cup23Got, cup24Got, cup25Got, cup26Got;

	// Use this for initialization
	void Start () {

		// Getting Player Prefs values to make sure you got
		// particular trophy
		cup1Got = PlayerPrefs.GetInt ("Cup1Got");
		cup2Got = PlayerPrefs.GetInt ("Cup2Got");
		cup3Got = PlayerPrefs.GetInt ("Cup3Got");
        cup4Got = PlayerPrefs.GetInt("Cup4Got");
        cup5Got = PlayerPrefs.GetInt("Cup5Got");
        cup6Got = PlayerPrefs.GetInt("Cup6Got");
        cup7Got = PlayerPrefs.GetInt("Cup7Got");
        cup8Got = PlayerPrefs.GetInt("Cup8Got");
        cup9Got = PlayerPrefs.GetInt("Cup9Got");
        cup10Got = PlayerPrefs.GetInt("Cup10Got");
        cup11Got = PlayerPrefs.GetInt("Cup11Got");
        cup12Got = PlayerPrefs.GetInt("Cup12Got");
        cup13Got = PlayerPrefs.GetInt("Cup13Got");
        cup14Got = PlayerPrefs.GetInt("Cup14Got");
        cup15Got = PlayerPrefs.GetInt("Cup15Got");
        cup16Got = PlayerPrefs.GetInt("Cup16Got");
        cup17Got = PlayerPrefs.GetInt("Cup17Got");
        cup18Got = PlayerPrefs.GetInt("Cup18Got");
        cup19Got = PlayerPrefs.GetInt("Cup19Got");
        cup20Got = PlayerPrefs.GetInt("Cup20Got");
        cup21Got = PlayerPrefs.GetInt("Cup21Got");
        cup22Got = PlayerPrefs.GetInt("Cup22Got");
        cup23Got = PlayerPrefs.GetInt("Cup23Got");
        cup24Got = PlayerPrefs.GetInt("Cup24Got");
        cup25Got = PlayerPrefs.GetInt("Cup25Got");
        cup26Got = PlayerPrefs.GetInt("Cup26Got");
        // If you got trophy 1
        if (cup1Got == 1)
			// then it is shown on the shelf
			cup1.SetActive (true);
		// if you don't get it
		else
			// then it is not shown
			cup1.SetActive (false);

		// Same for trophy 2 and 3
		if (cup2Got == 1)
			cup2.SetActive (true);
		else
			cup2.SetActive (false);
		
		if (cup3Got == 1)
			cup3.SetActive (true);
		else
			cup3.SetActive (false);

        if (cup4Got == 1)
            // then it is shown on the shelf
            cup4.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup4.SetActive(false);

        if (cup5Got == 1)
            // then it is shown on the shelf
            cup5.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup5.SetActive(false);

        if (cup6Got == 1)
            // then it is shown on the shelf
            cup6.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup6.SetActive(false);

        if (cup7Got == 1)
            // then it is shown on the shelf
            cup7.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup7.SetActive(false);

        if (cup8Got == 1)
            // then it is shown on the shelf
            cup8.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup8.SetActive(false);

        if (cup9Got == 1)
            // then it is shown on the shelf
            cup9.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup9.SetActive(false);

        if (cup10Got == 1)
            // then it is shown on the shelf
            cup10.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup10.SetActive(false);

        if (cup11Got == 1)
            // then it is shown on the shelf
            cup11.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup11.SetActive(false);

        if (cup12Got == 1)
            // then it is shown on the shelf
            cup12.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup12.SetActive(false);

        if (cup13Got == 1)
            // then it is shown on the shelf
            cup13.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup13.SetActive(false);

        if (cup14Got == 1)
            // then it is shown on the shelf
            cup14.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup14.SetActive(false);

        if (cup15Got == 1)
            // then it is shown on the shelf
            cup15.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup15.SetActive(false);

        if (cup16Got == 1)
            // then it is shown on the shelf
            cup16.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup16.SetActive(false);

        if (cup17Got == 1)
            // then it is shown on the shelf
            cup17.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup17.SetActive(false);

        if (cup18Got == 1)
            // then it is shown on the shelf
            cup18.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup18.SetActive(false);

        if (cup19Got == 1)
            // then it is shown on the shelf
            cup19.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup19.SetActive(false);

        if (cup20Got == 1)
            // then it is shown on the shelf
            cup20.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup20.SetActive(false);

        if (cup21Got == 1)
            // then it is shown on the shelf
            cup21.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup21.SetActive(false);

        if (cup22Got == 1)
            // then it is shown on the shelf
            cup22.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup22.SetActive(false);

        if (cup23Got == 1)
            // then it is shown on the shelf
            cup23.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup23.SetActive(false);

        if (cup24Got == 1)
            // then it is shown on the shelf
            cup24.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup24.SetActive(false);

        if (cup25Got == 1)
            // then it is shown on the shelf
            cup25.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup25.SetActive(false);

        if (cup26Got == 1)
            // then it is shown on the shelf
            cup26.SetActive(true);
        // if you don't get it
        else
            // then it is not shown
            cup26.SetActive(false);
    }

}
