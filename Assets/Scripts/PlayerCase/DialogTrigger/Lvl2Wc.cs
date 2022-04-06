using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl2Wc : MonoBehaviour
{
    public JoeCaseWc2 joeCase;
    public BillCaseWc billCase;
    public  BorisCaseWc borisCase;


    public GameObject timer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Joe")
        {
            timer.SetActive(false);
            joeCase.JoeDialog();
            print("Colide");
        }

        if (collision.gameObject.tag == "Bill")
        {
            timer.SetActive(false);
            billCase.BillDialog();
        }

        if (collision.gameObject.tag == "Boris")
        {
            timer.SetActive(false);
            borisCase.BorisDialog();
        }
    }
}
