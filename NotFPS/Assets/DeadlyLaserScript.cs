﻿using UnityEngine;
using System.Collections;

public class DeadlyLaserScript : MonoBehaviour {
	public GameObject fpsController;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "Player")
			fpsController.GetComponent<ResetScript>().ResetPosition ();
	}
}
