using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockPlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Joe")
        {
            LockedPlayers.player2Lock = false;
        }
        if (collision.gameObject.tag == "Bill")
        {
            LockedPlayers.player3Lock = false;
        }
        if (collision.gameObject.tag == "Boris")
        {
            LockedPlayers.player4Lock = false;
        }
        
    }
}
