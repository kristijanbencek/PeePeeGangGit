using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drink : MonoBehaviour
{
    public BarSlider barSlider;

    public float fillSlider;
    public int score;

    public GameObject animScore;

    private void OnMouseDown()
    {
        barSlider.leftPeeLiquid += fillSlider;
        Instantiate(animScore, new Vector3(transform.position.x,1,0), Quaternion.identity);
        ScoreCount.countScore += score;
    }
}
