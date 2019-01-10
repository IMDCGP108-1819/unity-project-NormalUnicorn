using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class user_input : MonoBehaviour {
	public GameObject fired_beam_prefab;
	private float StartTime;
	public float LifeTime = 0.2f;
	private GameObject fired_beam;
	// Use this for initialization

	void Start () {
		StartTime = Time.time;
		fired_beam = Instantiate(fired_beam_prefab);
		fired_beam.SetActive(false);
	}

	// Update is called once per frame
	void Update () {
		if (Time.time >= StartTime + LifeTime) {
			if (Input.GetKeyDown("space")) {
				fired_beam.SetActive(true);
				fired_beam.transform.position = transform.position;
				StartTime = Time.time;
			} else {
                 		// the bullet is set to inactive, so it vanishes.
				// github chris
                 		fired_beam.SetActive(false);
	     		}
       	}
	}
}
