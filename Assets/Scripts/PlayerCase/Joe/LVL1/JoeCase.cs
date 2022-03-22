using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoeCase : MonoBehaviour
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

    [Header("Dialog 3 Barmen")]
    public float dialogBarmen3Start;
    public GameObject dialogBarmen3;
    public float dialogBarmen3End;

    // Joe
    [Header("Dialog 1 Joe")]
    public float dialogJoe1Start;
    public GameObject dialogJoe1;
    public float dialogJoe1End;

    [Header("Dialog 2 Joe")]
    public float dialogJoe2Start;
    public GameObject dialogJoe2;
    public float dialogJoe2End;

    void Start()
    {
        Invoke("MovementWc1", moveDelay);
        Invoke("DrinkPanelActive", drinkPanelDelay);

        
        BarmenDialog();
        JoeDialog();
    }

    void DrinkPanelActive()
    {
        drinkPanel.SetActive(true);
    }



    // Wc scene
    void MovementWc1()
    {
        moveBar.move1 = true;
    }

    //*******************BarmenLvl1Bar
    void BarmenDialog()
    {
        Invoke("DialogBarmen1Start", dialogBarmen1Start);
        Invoke("DialogBarmen1End", dialogBarmen1End);

        Invoke("DialogBarmen2Start", dialogBarmen2Start);
        Invoke("DialogBarmen2End", dialogBarmen2End);

        Invoke("DialogBarmen3Start", dialogBarmen3Start);
        Invoke("DialogBarmen3End", dialogBarmen3End);
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

    // Dialog3
    void DialogBarmen3Start()
    {
        dialogBarmen3.SetActive(true);
    }
    void DialogBarmen3End()
    {
        dialogBarmen3.SetActive(false);
    }

    //*******************JoeLvl1Bar
    void JoeDialog()
    {
        Invoke("DialogJoe1Start", dialogJoe1Start);
        Invoke("DialogJoe1End", dialogJoe1End);

        Invoke("DialogJoe2Start", dialogJoe2Start);
        Invoke("DialogJoe2End", dialogJoe2End);
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

    // Dialog1
    void DialogJoe2Start()
    {
        dialogJoe2.SetActive(true);
    }
    void DialogJoe2End()
    {
        dialogJoe2.SetActive(false);
    }
}
