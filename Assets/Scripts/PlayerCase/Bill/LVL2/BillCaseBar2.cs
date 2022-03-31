using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillCaseBar2 : MonoBehaviour
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

    // Bill
    [Header("Dialog 1 Bill")]
    public float dialogBill1Start;
    public GameObject dialogBill1;
    public float dialogBill1End;

    void Start()
    {
        Invoke("MovementWc1", moveDelay);
        Invoke("DrinkPanelActive", drinkPanelDelay);

        BarmenDialog();
        BillDialog();
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
    void BillDialog()
    {
        Invoke("DialogBill1Start", dialogBill1Start);
        Invoke("DialogBill1End", dialogBill1End);
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


}
