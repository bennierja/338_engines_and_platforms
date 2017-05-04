using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class StarRotation : MonoBehaviour {



public int speed = 4;

void Update () {
	transform.Rotate(0, speed, 0, Space.World);

}


}