using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkButton : MonoBehaviour
{
    public GameObject drinkPanel;

    public GameObject timer;
    public GameObject drinksToDrink;
    public GameObject drinksToMove;
    public GameObject lights;

   

    public void Active()
    {
        timer.SetActive(true);
        drinksToMove.SetActive(true);
        drinksToDrink.SetActive(true);
        lights.SetActive(true);
        drinkPanel.SetActive(false);
    }
}
