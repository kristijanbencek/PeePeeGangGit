using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllertButton : MonoBehaviour
{
    public GameObject allertPannel;
    public GameObject players;

    public void PanelShow()
    {
        allertPannel.SetActive(true);
        Time.timeScale = 0f;
        players.SetActive(false);
    }
    public void PanelClose()
    {
        allertPannel.SetActive(false);
        Time.timeScale = 1f;
        players.SetActive(true);
    }



}
