using UnityEngine;
using System.Collections;

using UnityEngine.UI;



public class StarPickup : MonoBehaviour {



public AudioSource starSound;
public GameObject scoreDisplay;
public static int theScore = 0;

void OnTriggerEnter (Collider col) {

	starSound.Play();


	transform.position = new Vector3 (0, 1000, 0);
	theScore += 1;
	scoreDisplay.GetComponent<Text>().text = "Score: " + theScore;
}


}