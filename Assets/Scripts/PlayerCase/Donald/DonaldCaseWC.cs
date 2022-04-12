using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonaldCaseWC : MonoBehaviour
{
    public GameObject pisoarToTouch;
    public GameObject peeSound;
    public GameObject timer;

    // Punk
    [Header("Dialog 1 Punk")]
    public float dialogPunk1Start;
    public GameObject dialogPunk1;
    public float dialogPunk1End;


    // Donald
    [Header("Dialog 1 Donalds")]
    public float dialogDonald1Start;
    public GameObject dialogDonald1;
    public float dialogDonald1End;

    // Donald
    [Header("Dialog 2 Donalds")]
    public float dialogDonald2Start;
    public GameObject dialogDonald2;
    public float dialogDonald2End;

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

    //*******************DonaldLvl1WC
    public void DonaldDialog()
    {
        peeSound.SetActive(true);
        Invoke("DialogDonald1Start", dialogDonald1Start);
        Invoke("DialogDonald1End", dialogDonald1End);

        Invoke("DialogDonald2Start", dialogDonald2Start);
        Invoke("DialogDonald2End", dialogDonald2End);
    }

    void DialogDonald1Start()
    {
        dialogDonald1.SetActive(true);
    }
    void DialogDonald1End()
    {
        dialogDonald1.SetActive(false);
    }

    void DialogDonald2Start()
    {
        dialogDonald2.SetActive(true);
    }
    void DialogDonald2End()
    {
        dialogDonald2.SetActive(false);
    }
}
