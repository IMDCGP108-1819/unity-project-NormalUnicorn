using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bob_spawning : MonoBehaviour {
	public Vector3 size;
	public bool is_left;
	public float tTimer; //tTimer is a point of time in the future
	public GameObject[] prefabs;

	// Use this for initialization
	void Start () {
		spawnArea();
	}

	// Update is called once per frame
	void Update () {
		// Thanks Will Terry :)
		// Waits until tTimer has passed and then calls function and generates new tTimer
		if (Time.time > tTimer) {
			spawnArea();
			tTimer = Time.time + Random.Range(1.0f,5.0f);
		}

	}
	// https://youtu.be/kTvBRkPTvRY - used this video to help with this function
	public void spawnArea() {
		// picks a random point along y axis
		Vector3 pos = new Vector3(0, Random.Range(-size.y/2, size.y/2), 0);
		// summons random prefab near GameObject using pos
		GameObject summoned_prefab = Instantiate(prefabs[Random.Range(0, prefabs.Length)], transform.position + pos, Quaternion.identity);
		// tells spawned object to go left or right
		summoned_prefab.GetComponent<movement>().direction = is_left;
	}
}
