using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BarSlider : MonoBehaviour
{
    public int scene;


    // Slider
    [Header("Slider")]

    public Image peeSlider;
    public float maxPeeLiquid;
    public float leftPeeLiquid;

    private void Start()
    {
        leftPeeLiquid = 0;
    }

    private void Update()
    {
        SliderManager();
    }

    private void SliderManager()
    {
        peeSlider.fillAmount = leftPeeLiquid;
        if (leftPeeLiquid >= maxPeeLiquid)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
