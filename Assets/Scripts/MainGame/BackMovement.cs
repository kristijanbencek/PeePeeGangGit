using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMovement : MonoBehaviour
{
   

    public GameObject player;

    public float playerSpeed;

    public GameObject peeOutline;

    public GameObject img;



    public void Update()
    {
        PlayerBackMovement();

    }

    public void OnMouseDown()
    {
        
        peeOutline.SetActive(false);
        img.SetActive(false);
    }

    void PlayerBackMovement()
    {
       
    }
}
