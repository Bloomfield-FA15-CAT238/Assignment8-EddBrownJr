﻿using UnityEngine;
using System.Collections;

public class Hazards : MonoBehaviour {

	public GameController gameControl;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter(Collider other)
	{
		
		if (other.gameObject.tag.Equals ("GamePlayers")) 
			gameControl.Damage();
		
	}
}
