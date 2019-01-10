using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bob_spawning : MonoBehaviour {
	[System.Serializable]
	public class Pool {
		public string tag;
		public GameObject prefab;
		public int size;
	}



	public List<Pool> pools;

	public Vector3 size;
	public bool is_left;
	public float tTimer; //tTimer is a point of time in the future
	public GameObject[] prefabs;
	public Dictionary<string, Queue<GameObject>> prefab_dict;
	//Use this for initialization
	void Start () {
		prefab_dict = new Dictionary<string, Queue<GameObject>>(); {}

		foreach (Pool pool in pools) {
			Queue<GameObject> objectPool = new Queue<GameObject>();

			for (int i = 0; i < pool.size; i++) {
				Instantiate(pool.prefabs);
				gameObject.SetActive(false);
				objectPool.Enqueue(gameObject);
			}

			prefab_dict.Add(pool.tag, objectPool);
		}
		Debug.Log(prefab_dict);

	}

	public GameObject SpawnFromPool(string tag, Vector3 pos, Quaternion rotation) {
		GameObject object_to_spawn = prefab_dict[tag].Dequeue();

		object_to_spawn.SetActive(true);
		object_to_spawn.transform.position = pos;
		object_to_spawn.transform.rotation = rotation;

		prefab_dict[tag].Enqueue(object_to_spawn);

		return object_to_spawn;
	}



	// Update is called once per frame
	void Update () {
		// Thanks Will Terry :)
		// Waits until tTimer has passed and then calls function and generates new tTimer
		if (Time.time > tTimer) {
			SpawnFromPool("fast", transform.position, Quaternion.identity);
			tTimer = Time.time + Random.Range(4.0f,10.0f);
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
