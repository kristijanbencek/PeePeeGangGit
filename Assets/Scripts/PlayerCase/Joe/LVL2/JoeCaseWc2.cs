using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoeCaseWc2 : MonoBehaviour
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

    // Joe
    [Header("Dialog 1 Joe")]
    public float dialogJoe1Start;
    public GameObject dialogJoe1;
    public float dialogJoe1End;

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
        pisoarToTouch.SetActive(true);
        dialogPunk1.SetActive(false);
        timer.SetActive(true);
    }

    //*******************JoeLvl1WC
    public void JoeDialog()
    {
        peeSound.SetActive(true);
        Invoke("DialogJoe1Start", dialogJoe1Start);
        Invoke("DialogJoe1End", dialogJoe1End);

    }

    void DialogJoe1Start()
    {
        dialogJoe1.SetActive(true);
    }
    void DialogJoe1End()
    {
        dialogJoe1.SetActive(false);
    }
}
