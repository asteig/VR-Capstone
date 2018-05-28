using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSize : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Debug.Log (GameObject.tag);
        Collider m_collider = GetComponent<Collider>();
		Debug.Log (m_collider.bounds);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}