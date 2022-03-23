using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Arrows to choose which player is selected to play
public class SelectedPlayer : MonoBehaviour
{
    //Vrati ovo
    //public static int selectedPlayer;

    public static int selectedPlayer = 1;

    // i ovo
    //public static int playerCase;

    public static int playerCase = 1;


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
        if (selectedPlayer >= 1 && playerCase >= 1)
        {
            selectedPlayer = 1;
            playerCase = 1;
        }
    }
}
