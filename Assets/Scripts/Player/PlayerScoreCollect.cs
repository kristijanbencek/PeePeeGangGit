using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScoreCollect : MonoBehaviour
{
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "200+")
        {
            ScoreCount.countScore += 200;
            print("radi");
        }
        if (collision.gameObject.tag == "400+")
        {
            ScoreCount.countScore += 400;
            print("radi");
        }
    }
  
    
}
