using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailsPoint : MonoBehaviour
{

    public bool isDead;
    public bool hasLeft;

    public GameObject next;
    public RailsPoint nextPoint;


    // Use this for initialization
    void Start()
    {
        nextPoint = nextPoint.next.GetComponent<RailsPoint>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void HasLeft() {
        
    } 

}
