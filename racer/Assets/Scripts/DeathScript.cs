using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class DeathScript : MonoBehaviour {

public GameObject deathBlack;
public GameObject theRocket;
public GameObject mainAudio;
public AudioSource crashAudio;

void OnTriggerEnter (Collider col) {

	deathBlack.SetActive(true);

	theRocket.SetActive(false);

	mainAudio.SetActive(false);

	crashAudio.Play();

	NextAxis.theXAxis = 60;

}

}