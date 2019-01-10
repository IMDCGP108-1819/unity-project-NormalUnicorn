using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	public float movement_speed;
	public bool direction;
	public float StartTime;
	public float LifeTime = 3.0f;
	public int score; 
	// Use this for initialization
	void Start () {
		StartTime = Time.time;
	}

	// Update is called once per frame
	void Update () {
		// if direction = true, moves to the left
		if (direction) {
			transform.position += new Vector3(movement_speed*Time.deltaTime, 0f);
		} else {
			transform.position -= new Vector3(movement_speed*Time.deltaTime, 0f);
		}
		if (Time.time > StartTime+LifeTime) {
//			gameObject.SetActive(false);
		}
	}
}
