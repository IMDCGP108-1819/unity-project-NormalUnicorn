using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	public float movement_speed;
	public bool direction;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// if direction = true, moves to the left 
		if (direction) {
			transform.position += new Vector3(movement_speed*Time.deltaTime, 0f);
		} else {
			transform.position -= new Vector3(movement_speed*Time.deltaTime, 0f);
		}
	}
}
