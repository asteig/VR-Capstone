﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour {

    public string LevelName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col) {
        Debug.Log("Collision");

        if (col.gameObject.name.Contains("Player"))
        {
            SceneManager.LoadScene (LevelName);
        }
	}

}
