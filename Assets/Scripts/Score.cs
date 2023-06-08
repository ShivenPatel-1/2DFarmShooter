using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreValue;
    //private Text score;

    void Start()
    {
        //score = GetComponent<Text>();
        scoreValue = 0;
        //score.text = "Score: " + scoreValue;
    }

    void Update()
    {
        //score.text = "Score: " + scoreValue;
        if (Input.GetKeyDown("x"))
        {
            Debug.Log(scoreValue);
        }
    }
}
