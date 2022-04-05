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
    [Header("Dialog 2 Boris")]
    public float dialogBoris1Start;
    public GameObject dialogBoris1;
    public float dialogBoris1End;

    void Start()
    {
        Invoke("MovementWc1", moveDelay);
        Invoke("DrinkPanelActive", drinkPanelDelay);

        BarmenDialog();
    }

    // Wc scene
    void MovementWc1()
    {
        moveBar.move1 = true;
    }

    //*******************BarmenLvl1Bar
    void BarmenDialog()
    {
        Invoke("DialogBarmen1Start", dialogBoris1Start);
        Invoke("DialogBarmen1End", dialogBoris1End);

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

    //*******************BillLvl1Bar
    void BillDialog()
    {
        Invoke("DialogBoris1Start", dialogBoris1Start);
        Invoke("DialogBoris1End", dialogBoris1End);

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
}
