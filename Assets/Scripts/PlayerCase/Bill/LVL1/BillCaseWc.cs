using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillCaseWc : MonoBehaviour
{
    public GameObject pisoarToTouch;
    public GameObject peeSound;
    public GameObject timer;

    // Punk
    [Header("Dialog 1 Punk")]
    public float dialogPunk1Start;
    public GameObject dialogPunk1;
    public float dialogPunk1End;

    // Bill
    [Header("Dialog 1 Bill")]
    public float dialogBill1Start;
    public GameObject dialogBill1;
    public float dialogBill1End;



    private void Start()
    {
        PunkDialog();
    }

    //*******************PunkLvl1Bar
    void PunkDialog()
    {
        Invoke("DialogPunk1Start", dialogPunk1Start);
        Invoke("DialogPunk1End", dialogPunk1End);
    }

    // Dialog1
    void DialogPunk1Start()
    {
        dialogPunk1.SetActive(true);
    }
    void DialogPunk1End()
    {
        timer.SetActive(true);
        pisoarToTouch.SetActive(true);
        dialogPunk1.SetActive(false);
    }

    //*******************BillLvl1WC
    public void BillDialog()
    {
        peeSound.SetActive(true);
        Invoke("DialogBill1Start", dialogBill1Start);
        Invoke("DialogBill1End", dialogBill1End);

    }

    void DialogBill1Start()
    {
        dialogBill1.SetActive(true);
    }
    void DialogBill1End()
    {
        dialogBill1.SetActive(false);
    }


}
