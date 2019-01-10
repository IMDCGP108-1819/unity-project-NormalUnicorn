using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class beam_movement : MonoBehaviour {
    public float movement_speed;
    public Rigidbody2D RigidBody2D;
    public GameObject score;
    public GameObject lives;
    public GameObject end_pannel;
    // Start is called before the first frame update
    void Start()
    {
          lives = GameObject.Find("Lives");
          RigidBody2D = this.GetComponent<Rigidbody2D>();
          score = GameObject.Find("score");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, movement_speed*Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other) {
          if (other.gameObject.tag == "goal1") {
                other.gameObject.SetActive(false);
                this.gameObject.SetActive(false);
                score.GetComponent<scoring>().score += 1;
          } else if (other.gameObject.tag == "goal2") {
                other.gameObject.SetActive(false);
                this.gameObject.SetActive(false);
                score.GetComponent<scoring>().score += 3;
         } else if (other.gameObject.tag == "goal3") {
               other.gameObject.SetActive(false);
               other.gameObject.SetActive(false);
               score.GetComponent<scoring>().score += 5;
         } else if (other.gameObject.tag == "boundry") {
               this.gameObject.SetActive(false);
               lives.GetComponent<lives>().lives_counter -= 1;
               if (lives.GetComponent<lives>().lives_counter == 0) {
                     end_pannel.SetActive(true);
               }
         }
   }
}
