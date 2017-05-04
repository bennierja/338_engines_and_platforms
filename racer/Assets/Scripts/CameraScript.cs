using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class CameraScript : MonoBehaviour {



public Transform cameraTarget;
public float targetDistance = 12.0f;
public float cameraY = 0.0f;

void Update () {

	transform.position = new Vector3(transform.position.x, transform.position.y, cameraTarget.position.z - targetDistance);
	transform.position = new Vector3(cameraTarget.position.x + 7, transform.position.y, transform.position.z);
}


void LateUpdate () {

	transform.position = new Vector3(transform.position.x, cameraY, transform.position.z);
}


}