using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerBar : MonoBehaviour
{
    // Slider
    [Header("Slider")]

    public Image timeSlider;
    public float maxTime;
    public static float timeLeft;
    public GameObject slowDrinker;

    

    private void Start()
    {
        timeLeft = maxTime;       
    }

    private void Update()
    {
        SliderManagment();
    }

    void SliderManagment()
    {
        timeLeft -= 1 * Time.deltaTime;
        timeSlider.fillAmount = timeLeft / maxTime;
        if (timeLeft < 0)
        {
            slowDrinker.SetActive(true);
        }
    }
}
