using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class GenerateSections : MonoBehaviour {



public GameObject section1;

public GameObject section2;

public GameObject section3;

public GameObject section4;

public GameObject section5;

public GameObject section6;

public GameObject section7;

public GameObject section8;

public GameObject section9;



public int nextAxis = NextAxis.theXAxis;

public int genSec;

public GameObject newSec;

public Vector3 nextPosition = new Vector3(NextAxis.theXAxis, 0, 0);

void OnTriggerEnter (Collider col) {
	nextPosition = new Vector3(NextAxis.theXAxis, 0, 0);
	genSec = Random.Range(1,10);
	nextAxis = NextAxis.theXAxis;

	if (genSec == 1) {
		newSec = section1;
	}
	if (genSec == 2) {
		newSec = section2;
	}
	if (genSec == 3) {
		newSec = section3;
	}
	if (genSec == 4) {
		newSec = section4;
	}
	if (genSec == 5) {
		newSec = section5;
	}
	if (genSec == 6) {
		newSec = section6;
	}
	if (genSec == 7) {
		newSec = section7;
	}
	if (genSec == 8) {
		newSec = section8;
	}
	if (genSec == 9) {
		newSec = section9;
	}

	Instantiate(newSec, nextPosition, Quaternion.identity);
	NextAxis.theXAxis += 60;
}

}