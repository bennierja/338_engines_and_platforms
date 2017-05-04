using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class RocketMovement : MonoBehaviour {

public static float rocketSpeed = 10.00f;

public GameObject leftThruster;
public GameObject rightThruster;
public GameObject thrusterActivator;

public bool leftButtonOn = false;
public bool rightButtonOn = false;

public void PressingLeft () {
	leftButtonOn = true;
}
public void UnpressingLeft () {
	leftButtonOn = false;
}

public void PressingRight () {
	rightButtonOn = true;
}
public void UnpressingRight () {
	rightButtonOn = false;
}

void UpMover () {
	if (gameObject.transform.position.y < 5.5) {
		gameObject.transform.Translate (Vector3.up * rocketSpeed * Time.deltaTime, Space.World);
	}
}

void DownMover () {
	if (gameObject.transform.position.y > -5.5) {
		gameObject.transform.Translate (Vector3.down * rocketSpeed * Time.deltaTime, Space.World);
	}
}

void Start () {
	rocketSpeed = 10.00f;
}

void Update () {

	gameObject.transform.Translate(Vector3.right * rocketSpeed * Time.deltaTime, Space.World);
	
	if (leftButtonOn || Input.GetKey ("up")) {
		UpMover();
		leftThruster.SetActive(true);
	} else {
		leftThruster.SetActive(false);
	}

	if (rightButtonOn || Input.GetKey ("down")) {
		DownMover();
		rightThruster.SetActive(true);
	} else {
		rightThruster.SetActive(false);
	}

	if (leftButtonOn || Input.GetKey ("up") || rightButtonOn || Input.GetKey ("down")) {
		thrusterActivator.SetActive(true);
	} else {
		thrusterActivator.SetActive(false);
	}

}

}