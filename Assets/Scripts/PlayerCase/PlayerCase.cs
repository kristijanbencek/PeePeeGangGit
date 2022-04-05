using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCase : MonoBehaviour
{
    public GameObject joeCase, billCase, borisCase;

    private void Update()
    {
        PlayerDialog();
    }
    void PlayerDialog()
    {
        switch (SelectedPlayer.playerCase)
        {
            case 0:
                joeCase.SetActive(true);
                break;

            case 1:
                billCase.SetActive(true);
                break;

            case 2:
                borisCase.SetActive(true);
                break;
        }
    }
}
