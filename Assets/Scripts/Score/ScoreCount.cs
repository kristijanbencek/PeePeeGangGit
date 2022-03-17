using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    public static float countScore;
    public float score;

    private void Update()
    {
        score = countScore;
    }
}
