using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeat : MonoBehaviour {

Vector3 thisTransform;
float timesReset = 0;

	// Use this for initialization
	void Start () {
		thisTransform=gameObject.transform.position;

	}
	
	// Update is called once per frame
	void Update () {

	if(Time.realtimeSinceStartup-timesReset*3>3f)
	{gameObject.transform.position=thisTransform;

	timesReset++;


	}


				
	}
}
