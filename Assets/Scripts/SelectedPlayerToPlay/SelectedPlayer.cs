using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Arrows to choose which player is selected to play
public class SelectedPlayer : MonoBehaviour
{

    public static int selectedPlayer = 2;

    public static int playerCase = 2;


    private void Start()
    {
        selectedPlayer = 0;       
    }


    public void LeftArrow()
    {
        playerCase--;
        selectedPlayer--;
        if (selectedPlayer <= 0 && playerCase <= 0)
        {
            selectedPlayer = 0;
            playerCase = 0;
        }
    }

    public void RightArrow()
    {
        playerCase++;
        selectedPlayer++;
        if (selectedPlayer >= 2 && playerCase >= 2)
        {
            selectedPlayer = 2;
            playerCase = 2;
        }
    }
}
