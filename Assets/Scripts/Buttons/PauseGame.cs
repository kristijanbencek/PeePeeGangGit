using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{

    bool isPaused;

    private void Start()
    {
        isPaused = false;
    }

    public void Pause()
    {
        if (!isPaused)
        {
            Time.timeScale = 0f;
            AudioListener.pause = true;
            isPaused = true;
        }
        else if (isPaused)
        {
            Time.timeScale = 1f;
            AudioListener.pause = false;
            isPaused = false;
        }
    }
    
}
