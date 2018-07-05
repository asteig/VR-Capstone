using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailsMovement : MonoBehaviour {

	public RailsPoint nextPoint;
	private bool started = true;
	public float speed = 2.0f;
    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1") && started==false) {
			started = true; 
		}

		if (started) {
			MoveNext ();
		}

		if (Vector3.Distance (transform.position, nextPoint.transform.position) < 0.25f) {
			StartCoroutine (Turn ());
		}

	}

	void MoveNext () {

        transform.position = new Vector3(transform.position.x, 1.09f, transform.position.z);
		transform.position = Vector3.MoveTowards (transform.position, nextPoint.transform.position, (speed*Time.deltaTime));
	}

	IEnumerator Turn () {
		started = false;

        nextPoint = nextPoint.next.GetComponent<RailsPoint>();

		Quaternion currentRotation = transform.rotation;

		GameObject dummy = Instantiate(new GameObject(), transform.position, transform.rotation) as GameObject;

	
		dummy.transform.LookAt (nextPoint.transform.position);

		Quaternion targetRotation = dummy.transform.rotation;
		Destroy(dummy);
		for (float i = 0.0f; i <= 1; i+=0.1f) {
			yield return new WaitForSeconds(0.0f);
			transform.rotation = Quaternion.Lerp (currentRotation, targetRotation, i);
		}


		started = true;
	}


}
