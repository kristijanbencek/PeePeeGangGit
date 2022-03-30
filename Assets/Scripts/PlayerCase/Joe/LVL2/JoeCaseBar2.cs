using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoeCaseBar2 : MonoBehaviour
{
    [Header("Other Script")]
    public PisoarPosition moveBar;

    [Header("Panels")]
    public GameObject drinkPanel;

    [Header("Delays")]
    public float moveDelay;
    public float drinkPanelDelay;

    // Joe
    [Header("Dialog 1 Joe")]
    public float dialogJoe1Start;
    public GameObject dialogJoe1;
    public float dialogJoe1End;

    // Barmen
    [Header("Dialog 1 Barmen")]
    public float dialogBarmen1Start;
    public GameObject dialogBarmen1;
    public float dialogBarmen1End;

    void Start()
    {
        Invoke("MovementWc1", moveDelay);
        Invoke("DrinkPanelActive", drinkPanelDelay);

        BarmenDialog();
        JoeDialog();
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


    //*******************BarmenLvl2Bar
    void BarmenDialog()
    {
        Invoke("DialogBarmen1Start", dialogBarmen1Start);
        Invoke("DialogBarmen1End", dialogBarmen1End);
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


    //*******************JoeLvl2Bar
    void JoeDialog()
    {
        Invoke("DialogJoe1Start", dialogJoe1Start);
        Invoke("DialogJoe1End", dialogJoe1End);
    }

    // Dialog1
    void DialogJoe1Start()
    {
        dialogJoe1.SetActive(true);
    }
    void DialogJoe1End()
    {
        dialogJoe1.SetActive(false);
    }
}
