using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Arrows to choose which player is selected to play
public class SelectedPlayer : MonoBehaviour
{
    public static int selectedPlayer;


    public static int playerCase;

    //Ovo izbrisi kad zavrsis sa playerima
    //public static int playerCase = 1;

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
        if (selectedPlayer >= 3 && playerCase >= 3)
        {
            selectedPlayer = 3;
            playerCase = 3;
        }
    }
}
