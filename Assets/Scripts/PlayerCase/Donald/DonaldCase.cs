using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonaldCase : MonoBehaviour
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


    // Donald
    [Header("Dialog 1 Donald")]
    public float dialogDonald1Start;
    public GameObject dialogDonald1;
    public float dialogDonald1End;

    [Header("Dialog 2 Donald")]
    public float dialogDonald2Start;
    public GameObject dialogDonald2;
    public float dialogDonald2End;



    void Start()
    {
        Invoke("MovementWc1", moveDelay);
        Invoke("DrinkPanelActive", drinkPanelDelay);

        BarmenDialog();
        DonaldDialog();
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
    void DonaldDialog()
    {
        Invoke("DialogDonald1Start", dialogDonald1Start);
        Invoke("DialogDonald1End", dialogDonald1End);

        Invoke("DialogDonald2Start", dialogDonald2Start);
        Invoke("DialogDonald2End", dialogDonald2End);
    }

    // Dialog1
    void DialogDonald1Start()
    {
        dialogDonald1.SetActive(true);
    }
    void DialogDonald1End()
    {
        dialogDonald1.SetActive(false);
    }


    // Dialog2
    void DialogDonald2Start()
    {
        dialogDonald2.SetActive(true);
    }
    void DialogDonald2End()
    {
        dialogDonald2.SetActive(false);
    }



}
