using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeScoreTicket : MonoBehaviour
{
    public GameObject scoreText;
    void Start()
    {
        Invoke("ScoreTXTDelay", 0.9f);
    }

    void ScoreTXTDelay()
    {
        scoreText.SetActive(true);
    }
}
