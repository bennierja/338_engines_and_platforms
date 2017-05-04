using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyOrQuit1 : MonoBehaviour {

public GameObject deathAudio;

public void FlyAgain () {
	Application.LoadLevel(2);
}

public void MainMenu () {
	Application.LoadLevel(0);
}

IEnumerator Start () {
	yield return new WaitForSeconds (2);
	deathAudio.SetActive(true);
}

}