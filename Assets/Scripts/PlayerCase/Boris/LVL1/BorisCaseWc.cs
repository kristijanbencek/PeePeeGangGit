using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorisCaseWc : MonoBehaviour
{
    public GameObject pisoarToTouch;
    public GameObject peeSound;
    public GameObject timer;

    // Punk
    [Header("Dialog 1 Punk")]
    public float dialogPunk1Start;
    public GameObject dialogPunk1;
    public float dialogPunk1End;

    // Punk
    [Header("Dialog 2 Punk")]
    public float dialogPunk2Start;
    public GameObject dialogPunk2;
    public float dialogPunk2End;


    // Boris
    [Header("Dialog 1 Boris")]
    public float dialogBoris1Start;
    public GameObject dialogBoris1;
    public float dialogBoris1End;



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

    // Dialog2
    void DialogPunk2Start()
    {
        dialogPunk2.SetActive(true);
    }
    void DialogPunk2End()
    {
        dialogPunk2.SetActive(false);
    }

    //*******************BorisLvl1WC
    public void BorisDialog()
    {
        peeSound.SetActive(true);
        Invoke("DialogBoris1Start", dialogBoris1Start);
        Invoke("DialogBoris1End", dialogBoris1End);

        Invoke("DialogPunk2Start", dialogPunk2Start);
        Invoke("DialogPunk2End", dialogPunk2End);

    }

    void DialogBoris1Start()
    {
        dialogBoris1.SetActive(true);
    }
    void DialogBoris1End()
    {
        dialogBoris1.SetActive(false);
    }

}
