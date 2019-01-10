using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	public float movement_speed;
	public bool direction;
	public float StartTime;
	public float LifeTime = 3.0f;

	// Use this for initialization
	void Start () {
		StartTime = Time.time;
	}

	// private GameObject GetBullet() {
      //   // loop from 0 to MaxBullets, adding 1 each time we complete a loop
      //   for (int i = 0; i < MaxBob; i++) {
      //       // if the bullet in bulletList at position i is not active in the scene
      //       if (!bulletList[i].activeSelf) {
      //           // then return it.
      //           // returning will stop any further checks against other bullets
      //           return bulletList[i];
      //       }
      //   }
	//
      //   // if we reach here, there are no available bullets and we cannot fire.
      //   return null;
	// }


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
