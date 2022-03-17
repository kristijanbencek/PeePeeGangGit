using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Timer : MonoBehaviour
{
    // Slider
    [Header("Slider")]
    public Image timeSlider;
    public float maxTime;
    public static float timeLeft;

    // GameObjects
    [Header("GameObjects")]
    public GameObject endPanel;
    
    

    // Audio  
    [Header("Audio based on time")]
    public AudioSource[] audioSource;
    public AudioClip[] audioClip;


    [Header("Bad Choice")]
    public float playBadAfterSec;
    bool alreadyPlayedBad;

    [Header("ClockSecound")]
    public GameObject clockSecound;
    public Text secountTXT;

    

    void Start()
    {      
        timeLeft = maxTime;
    }

   
    void Update()
    {
        SliderManagment();
    }

    void SliderManagment()
    {
        if (timeLeft > 0)
        {
            timeLeft -= 1 * Time.deltaTime;
            timeSlider.fillAmount = timeLeft / maxTime;
            BadSound();
            ChangeClock();

        }      
        else
        {
            endPanel.SetActive(true);       
        }
    }

    void BadSound()
    {
        if (timeLeft < playBadAfterSec)
        {
            if (!alreadyPlayedBad)
            {
                audioSource[1].PlayOneShot(audioClip[1], 1);
                alreadyPlayedBad = true;
            }
        }
    }

    void ChangeClock()
    {
        if(timeLeft < 5.5f)
        {
            clockSecound.SetActive(true);
            secountTXT.text = timeLeft.ToString("0");
        }
    }

  

}
