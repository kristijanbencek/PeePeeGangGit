using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWithPlayer : MonoBehaviour
{
    // Number which player is selected to play
    public int selectedPlayerToPlay;

    // Varible that saves players in array
    public GameObject[] player;


    private void Start()
    {

        selectedPlayerToPlay = SelectedPlayer.selectedPlayer;
    }

    private void Update()
    {
        ActivatePlayer();
    }

    // Method which activate selected player
    public void ActivatePlayer()
    {
        switch (selectedPlayerToPlay)
        {
            case 0:
                player[0].SetActive(true);
                break;

            case 1:
                player[1].SetActive(true);
                break;

            case 2:
                player[2].SetActive(true);
                break;

            case 3:
                player[3].SetActive(true);
                break;

            case 4:
                player[4].SetActive(true);
                break;
        }
    }
}
