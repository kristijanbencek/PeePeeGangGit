using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl1Wc : MonoBehaviour
{
    public JoeCaseWc joeCase;
    public BillCaseWc billCase;
    public BorisCaseWc borisCase;
    public DonaldCaseWC donaldCase;


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
        if (collision.gameObject.tag == "Boris")
        {
            timer.SetActive(false);
            borisCase.BorisDialog();
        }
        if (collision.gameObject.tag == "Donald")
        {
            timer.SetActive(false);
            donaldCase.DonaldDialog();
        }
    }
}
