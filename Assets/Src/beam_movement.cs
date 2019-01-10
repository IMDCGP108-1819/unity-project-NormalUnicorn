using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beam_movement : MonoBehaviour {
    public float movement_speed;
    public Rigidbody2D RigidBody2D;
    // Start is called before the first frame update
    void Start()
    {
          RigidBody2D = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, movement_speed*Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other) {
          if (other.gameObject.tag == "goal") {
                Debug.Log("Hello there");
          }
   }
}
