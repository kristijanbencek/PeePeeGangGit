using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockedPlayers : MonoBehaviour
{
    public static bool 
        player2Lock = true, 
        player3Lock = true, 
        player4Lock = true;

    public GameObject player2Locker, player3Locker, player4Locker;

    public Button playButton;

    private void Update()
    {
        LockPlayer();
    }
    void LockPlayer()
    {
        if (player2Lock == true && SelectedPlayer.selectedPlayer == 1)
        {
            playButton.interactable = false;
            player2Locker.SetActive(true);
        }
        else if (player3Lock == true && SelectedPlayer.selectedPlayer == 2)
        {
            playButton.interactable = false;
            player3Locker.SetActive(true);
        }

        else if (player4Lock == true && SelectedPlayer.selectedPlayer == 3)
        {
            playButton.interactable = false;
            player4Locker.SetActive(true);
        }

        else
        {
            playButton.interactable = true;
            player2Locker.SetActive(false);
            player3Locker.SetActive(false);
            player4Locker.SetActive(false);
        }
    }
}
