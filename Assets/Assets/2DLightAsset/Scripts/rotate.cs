﻿using UnityEngine;

public class rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 euler = transform.localEulerAngles;
		euler.z += 2f;
		transform.localEulerAngles = euler;
	}
}
