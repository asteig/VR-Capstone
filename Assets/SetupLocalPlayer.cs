﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour {

	// Use this for initialization
	void Start () {

        Debug.Log("HERE!!!!!!!!");
		if(isLocalPlayer) {
            GetComponent<ToggleWalk>().enabled = true;    
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
