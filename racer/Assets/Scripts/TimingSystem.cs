using UnityEngine;
using System.Collections;

using UnityEngine.UI;


public class TimingSystem : MonoBehaviour {



void AddSpeed () {

	RocketMovement.rocketSpeed += 0.2f;
}

void Start () {

	InvokeRepeating("AddSpeed", 1, 1.0F);
}


}