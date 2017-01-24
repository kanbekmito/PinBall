using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {

    }
    private GameObject scoreText;
    void Start()
    {
        this.scoreText = GameObject.Find("GameScoreText");
    }

    void OnCollisionEnter(Collision other)
    {
        if (tag == "SmallStarTag")
        {
            this.scoreText.GetComponent<ScoreTex>().score += 5;
        }
        else if (tag == "LargeStarTag")
        {
            this.scoreText.GetComponent<ScoreTex>().score += 10;
        }
        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            this.scoreText.GetComponent<ScoreTex>().score += 20;
        }
    }
}