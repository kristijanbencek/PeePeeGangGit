using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillCase : MonoBehaviour
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

    // Bill
    [Header("Dialog 1 Bill")]
    public float dialogBill1Start;
    public GameObject dialogBill1;
    public float dialogBill1End;

    [Header("Dialog 2 Bill")]
    public float dialogBill2Start;
    public GameObject dialogBill2;
    public float dialogBill2End;


    void Start()
    {
        Invoke("MovementWc1", moveDelay);
        Invoke("DrinkPanelActive", drinkPanelDelay);


        BarmenDialog();
        BillDialog();
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

    // Dialog1
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
        Invoke("DialogBill1Start", dialogBill1Start);
        Invoke("DialogBill1End", dialogBill1End);

        Invoke("DialogBill2Start", dialogBill2Start);
        Invoke("DialogBill2End", dialogBill2End);
    }

    // Dialog1
    void DialogBill1Start()
    {
        dialogBill1.SetActive(true);
    }
    void DialogBill1End()
    {
        dialogBill1.SetActive(false);
    }

    // Dialog2
    void DialogBill2Start()
    {
        dialogBill2.SetActive(true);
    }
    void DialogBill2End()
    {
        dialogBill2.SetActive(false);
    }
}
