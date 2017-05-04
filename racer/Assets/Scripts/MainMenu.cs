using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class MainMenu : MonoBehaviour {

public void PlayLevel1 () {

	Application.LoadLevel(1);
}

public void PlayLevel2 () {

	Application.LoadLevel(3);
}

public void QuitGame () {

	Application.Quit();
}


}