using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GokuControl : MonoBehaviour {
    //private variables
    private float spd = 10f;
    private Rigidbody2D goku2D;

    //public variables
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    public KeyCode moveForward = KeyCode.D;
    public KeyCode moveBack = KeyCode.A;

    void GokuMove()
    {
        goku2D.AddForce(transform.forward * spd);
    }
	// Use this for initialization
	void Start () {
        goku2D = GetComponent<Rigidbody2D>();
        GokuMove();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(moveUp))
        {
            var vel = goku2D.velocity;
            vel.y = 5f;
            vel.x = spd;
            goku2D.velocity = vel;
        }
        else if (Input.GetKey(moveDown))
        {
            var vel = goku2D.velocity;
            vel.y = -1 * 5f;
            vel.x = spd;
            goku2D.velocity = vel;
        }
        else if (Input.GetKey(moveForward))
        {
            var vel = goku2D.velocity;
            vel.x = spd + 5f;
            goku2D.velocity = vel;
        }
        else if (Input.GetKey(moveBack))
        {
            var vel = goku2D.velocity;
            vel.x = spd;
            goku2D.velocity = vel;
        }
	}
}
