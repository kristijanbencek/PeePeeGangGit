using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorisCase : MonoBehaviour
{
    [Header("Other Script")]
    public PisoarPosition moveBar;

    [Header("Panels")]
    public GameObject drinkPanel;

    [Header("Delays")]
    public float moveDelay;
    public float drinkPanelDelay;


    // Barmen
    [Header("Dialog 1 Barmen")]
    public float dialogBarmen1Start;
    public GameObject dialogBarmen1;
    public float dialogBarmen1End;

    [Header("Dialog 2 Barmen")]
    public float dialogBarmen2Start;
    public GameObject dialogBarmen2;
    public float dialogBarmen2End;

    // Boris
    [Header("Dialog 1 Boris")]
    public float dialogBoris1Start;
    public GameObject dialogBoris1;
    public float dialogBoris1End;

    // Boris
    [Header("Dialog 2 Boris")]
    public float dialogBoris2Start;
    public GameObject dialogBoris2;
    public float dialogBoris2End;

    void Start()
    {
        Invoke("MovementWc1", moveDelay);
        Invoke("DrinkPanelActive", drinkPanelDelay);

        BarmenDialog();
        BorisDialog();
    }

    // Wc scene
    void MovementWc1()
    {
        moveBar.move1 = true;
    }

    void DrinkPanelActive()
    {
        drinkPanel.SetActive(true);
    }


    //*******************BarmenLvl1Bar
    void BarmenDialog()
    {
        Invoke("DialogBarmen1Start", dialogBarmen1Start);
        Invoke("DialogBarmen1End", dialogBarmen1End);

        Invoke("DialogBarmen2Start", dialogBarmen2Start);
        Invoke("DialogBarmen2End", dialogBarmen2End);
    }

    // Dialog1
    void DialogBarmen1Start()
    {
        dialogBarmen1.SetActive(true);
    }
    void DialogBarmen1End()
    {
        dialogBarmen1.SetActive(false);
    }

    // Dialog2
    void DialogBarmen2Start()
    {
        dialogBarmen2.SetActive(true);
    }
    void DialogBarmen2End()
    {
        dialogBarmen2.SetActive(false);
    }

    //*******************BorisLvl1Bar
    void BorisDialog()
    {
        Invoke("DialogBoris1Start", dialogBoris1Start);
        Invoke("DialogBoris1End", dialogBoris1End);

        Invoke("DialogBoris2Start", dialogBoris2Start);
        Invoke("DialogBoris2End", dialogBoris2End);

    }

    // Dialog1
    void DialogBoris1Start()
    {
        dialogBoris1.SetActive(true);
    }
    void DialogBoris1End()
    {
        dialogBoris1.SetActive(false);
    }

    // Dialog2
    void DialogBoris2Start()
    {
        dialogBoris2.SetActive(true);
    }
    void DialogBoris2End()
    {
        dialogBoris2.SetActive(false);
    }
}
