using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public float dispayScore;
    public Text scoreText;

    private void Update()
    {
        dispayScore = ScoreCount.countScore;
        scoreText.text = dispayScore.ToString("0");
    }

}
