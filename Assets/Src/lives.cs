using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lives : MonoBehaviour
{
      public int lives_counter;
      public Text diplayed_lives;
      public GameObject final_panel;
      public GameObject Spawn1;
      public GameObject Spawn2;
      public GameObject SpawnLaser;

    // Start is called before the first frame update
    void Start()
    {
       lives_counter = 3;
    }

    // Update is called once per frame
    void Update()
    {
          diplayed_lives.text = "Lives:" + lives_counter;
          if (lives_counter == 0) {
                final_panel.SetActive(true);
                Spawn1.SetActive(false);
                Spawn2.SetActive(false);
                SpawnLaser.SetActive(false);
          }
    }
}
