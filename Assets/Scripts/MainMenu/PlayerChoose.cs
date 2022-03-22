using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerChoose : MonoBehaviour
{
    public GameObject[] players;
    public GameObject[] playerNamesTXT;



    public int selectedPlayer = 0;

    private void Update()
    {
        SelecetPlayer();
    }

    void SelecetPlayer()
    {
        switch (selectedPlayer)
        {
            case 0:
                players[0].SetActive(true);
                players[1].SetActive(false);
                players[2].SetActive(false);
                players[3].SetActive(false);


                playerNamesTXT[0].SetActive(true);
                playerNamesTXT[1].SetActive(false);
                playerNamesTXT[2].SetActive(false);
                playerNamesTXT[3].SetActive(false);

                break;

            case 1:
                players[0].SetActive(false);
                players[1].SetActive(true);
                players[2].SetActive(false);
                players[3].SetActive(false);

                playerNamesTXT[0].SetActive(false);
                playerNamesTXT[1].SetActive(true);
                playerNamesTXT[2].SetActive(false);
                playerNamesTXT[3].SetActive(false);

                break;

            case 2:
                players[0].SetActive(false);
                players[1].SetActive(false);
                players[2].SetActive(true);
                players[3].SetActive(false);

                playerNamesTXT[0].SetActive(false);
                playerNamesTXT[1].SetActive(false);
                playerNamesTXT[2].SetActive(true);
                playerNamesTXT[3].SetActive(false);

                break;

            case 3:
                players[0].SetActive(false);
                players[1].SetActive(false);
                players[2].SetActive(false);
                players[3].SetActive(true);

                playerNamesTXT[0].SetActive(false);
                playerNamesTXT[1].SetActive(false);
                playerNamesTXT[2].SetActive(false);
                playerNamesTXT[3].SetActive(true);

                break;
        }
    }

    public void LeftArrow()
    {
        selectedPlayer--;
        if (selectedPlayer <= 0)
        {
            selectedPlayer = 0;
        }
    }
    public void RightArrow()
    {
        selectedPlayer++;
        if (selectedPlayer >= 1)
        {
            selectedPlayer = 1;
        }
    }

}
