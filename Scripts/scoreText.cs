using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class scoreText : MonoBehaviour
{
	Text ScoreText;
	public static int score;

    void Start()
    {
        score = 0;
        ScoreText = GetComponent<Text>();
    }

    void Update()
    {
        ScoreText.text = "Score: " + score;
    }
}
