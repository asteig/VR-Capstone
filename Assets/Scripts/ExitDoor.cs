using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour {

    public GameObject winsign;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {       
        if (col.gameObject.name.Contains("Player"))
        {
            winsign.SetActive(true);
        }
    }
}
