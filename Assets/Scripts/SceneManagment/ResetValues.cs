using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetValues : MonoBehaviour
{
    
        private void Awake()
    {
        Timer.timeLeft = 0;
        TimerBar.timeLeft = 0;
        ScoreCount.countScore = 0;
        SelectedPlayer.playerCase = 0;
        
    }
}
