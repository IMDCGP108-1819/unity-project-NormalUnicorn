using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lives : MonoBehaviour
{
      public int lives_counter;
      public Text diplayed_lives;
    // Start is called before the first frame update
    void Start()
    {
       lives_counter = 3;
    }

    // Update is called once per frame
    void Update()
    {
          diplayed_lives.text = "Lives:" + lives_counter;
    }
}
