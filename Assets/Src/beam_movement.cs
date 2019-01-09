using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beam_movement : MonoBehaviour {
    public float movement_speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, movement_speed*Time.deltaTime);
    }
}
