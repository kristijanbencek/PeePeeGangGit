using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoeCaseWc : MonoBehaviour
{
    public GameObject pisoarToTouch;
    public GameObject peeSound;

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

    // Joe
    [Header("Dialog 2 Joe")]
    public float dialogJoe2Start;
    public GameObject dialogJoe2;
    public float dialogJoe2End;


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
    }

    // Dialog1
    void DialogPunk2Start()
    {
        dialogPunk2.SetActive(true);
    }
    void DialogPunk2End()
    {       
        dialogPunk2.SetActive(false);
    }

    //*******************JoeLvl1WC



    public void JoeDialog()
    {
        peeSound.SetActive(true);
        Invoke("DialogJoe1Start", dialogJoe1Start);
        Invoke("DialogJoe1End", dialogJoe1End);

        Invoke("DialogJoe2Start", dialogJoe2Start);
        Invoke("DialogJoe2End", dialogJoe2End);

        Invoke("DialogPunk2Start", dialogPunk2Start);
        Invoke("DialogPunk2End", dialogPunk2End);
    }

    void DialogJoe1Start()
    {
        dialogJoe1.SetActive(true);
    }
    void DialogJoe1End()
    {
        dialogJoe1.SetActive(false);
    }

    void DialogJoe2Start()
    {
        dialogJoe2.SetActive(true);
    }
    void DialogJoe2End()
    {
        dialogJoe2.SetActive(false);
    }
}
