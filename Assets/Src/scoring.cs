﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour
{
    public int score;
    public Text displayed_score;
    public Text final_score;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
          displayed_score.text =  "score: " + score;
          final_score.text = "score: " + score;
    }
}
