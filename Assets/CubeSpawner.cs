﻿using UnityEngine;
using System.Collections;

public class CubeSpawner : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up * 30.0f * Time.deltaTime);
	}
}
