using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTex : MonoBehaviour {

    public int score = 0;
    private GameObject scoreText;

    // Use this for initialization
    void Start () {
        this.scoreText = GameObject.Find("GameScoreText");
    }
	
	// Update is called once per frame
	void Update () {
        scoreText.GetComponent<Text>().text = score.ToString();
    }
}
