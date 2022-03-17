using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Check value which pisoar is pressed
// This script is atacched to pisoar on level

public class PisoarChoosePos : MonoBehaviour
{
    public int levelCase;

    public PisoarPosition pisoarPos;
    

    public int pisoarNumber;

    void Update()
    {
        Invoke("BarLevelCase", 2f);     
    }
    private void OnMouseDown()
    {
        if(levelCase == 1)
        {
            switch (pisoarNumber)
            {
                case 1:
                    
                    break;

                case 2:
                    pisoarPos.move2 = true;
                    break;

                case 3:
                    pisoarPos.move3 = true;
                    break;

                case 4:
                    pisoarPos.move4 = true;
                    break;
            }
        }
    }

    void BarLevelCase()
    {
        if(levelCase == 0)
        {
            pisoarPos.move1 = true;
        }
    }
}
