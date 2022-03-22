using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InvokeScoreTicket : MonoBehaviour
{
    public int nextScene;
    public GameObject scoreText;
    void Start()
    {
        Invoke("ScoreTXTDelay", 0.9f);
        Invoke("SceneDelay", 2f);
    }

    void ScoreTXTDelay()
    {
        scoreText.SetActive(true);
    }

    void SceneDelay()
    {
        SceneManager.LoadScene(nextScene);
    }
}
