using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class user_input : MonoBehaviour {
	public GameObject fired_beam;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) {
			Instantiate(fired_beam, transform.position, Quaternion.identity);
		}
	}
}
