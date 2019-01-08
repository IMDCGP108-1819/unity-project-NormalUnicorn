using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bob_spawning : MonoBehaviour {
	public Vector3 size;
	public GameObject testPrefab;
	public bool is_left;

	// Use this for initialization
	void Start () {
		spawnArea1();
	}

	// Update is called once per frame
	void Update () {

	}

	public void spawnArea1() {
		// picks a random point in a rect
		Vector3 pos = new Vector3(Random.Range(-size.x/2, size.x/2), Random.Range(-size.y/2, size.y/2), 0);
		// summons prefab near GameObject using pos
		GameObject summoned_prefab = Instantiate(testPrefab, transform.position + pos, Quaternion.identity);
		// tells spawned object to go left or right 
		summoned_prefab.GetComponent<movement>().direction = is_left;
	}
}
