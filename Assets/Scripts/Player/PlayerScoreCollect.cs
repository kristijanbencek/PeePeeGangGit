using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScoreCollect : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "100")
        {
            ScoreCount.countScore = 100;
        }
        if (collision.gameObject.tag == "400")
        {
            ScoreCount.countScore = 400;
        }
        if (collision.gameObject.tag == "200")
        {
            ScoreCount.countScore = 200;
        }          
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "100+")
        {
            ScoreCount.countScore += 100;
        }
        if (collision.gameObject.tag == "200+")
        {
            ScoreCount.countScore += 200;
        }
        if (collision.gameObject.tag == "300+")
        {
            ScoreCount.countScore += 300;
        }
        if (collision.gameObject.tag == "500+")
        {
            ScoreCount.countScore += 500;
        }
        if (collision.gameObject.tag == "1000+")
        {
            ScoreCount.countScore += 1000;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "100")
        {
            ScoreCount.countScore = 0;
        }
        if (collision.gameObject.tag == "200")
        {
            ScoreCount.countScore = 0;
        }
        if (collision.gameObject.tag == "400")
        {
            ScoreCount.countScore = 0;
        }

        if (collision.gameObject.tag == "100+")
        {
            ScoreCount.countScore -= 100;
        }
        if (collision.gameObject.tag == "200+")
        {
            ScoreCount.countScore -= 200;
        }
        if (collision.gameObject.tag == "500+")
        {
            ScoreCount.countScore -= 500;
        }
        if (collision.gameObject.tag == "1000+")
        {
            ScoreCount.countScore -= 1000;
        }
    }

    
}
