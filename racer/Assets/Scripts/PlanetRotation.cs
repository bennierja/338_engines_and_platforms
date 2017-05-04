using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class PlanetRotation : MonoBehaviour {


public int speed = 1;

void Update () {
	transform.Rotate(0, speed, 0, Space.World);

}


}