using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleWalk : MonoBehaviour
{

    public Transform vrCamera;
    public float speed = 1.0f;
    public bool moveForward = false;

    private Rigidbody cc;

    // Use this for initialization
    void Start()
    {
        cc = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            moveForward = !moveForward;
        }

        if (moveForward)
        {
            cc.velocity = vrCamera.transform.forward * speed;
        }
        else
        {
            cc.velocity = Vector3.zero;
        }

    }

}