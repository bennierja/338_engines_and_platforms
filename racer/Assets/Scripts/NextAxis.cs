using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextAxis : MonoBehaviour {

	public static int theXAxis= 60;
	public int internalAxis;

	void Update () {
		internalAxis = theXAxis;
	}
}