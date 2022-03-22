using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl1Wc : MonoBehaviour
{
    public JoeCaseWc joeCase;
    public BillCaseWc billCase;


    public GameObject timer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Joe")
        {
            timer.SetActive(false);
            joeCase.JoeDialog();
        }

        if (collision.gameObject.tag == "Bill")
        {
            timer.SetActive(false);
            billCase.BillDialog();
        }
    }
}
