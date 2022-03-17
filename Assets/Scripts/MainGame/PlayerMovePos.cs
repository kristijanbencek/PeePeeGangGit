using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovePos : MonoBehaviour
{
    // Acess other scripts
    [Header("Other scripts")]
    //public GoBackButton backScript;
    public PisoarPosition pisoarPos;

    public Animator anim;

    [Header("Player speed")]
    public float speed;

    // Calculate pos for move
    [Header("")]
    public float xPos0, yPos0, xPos1, yPos1,
                 xPos2, yPos2, xPos3, yPos3, xPos4, yPos4;


    [Header("Positions to turn of/on animations/sound")]
    public float yPosEnd;
    public float yPosMiddle;
    public float yPosStart;

    // Decide if player can move
    [Header("Check if player can move")]
    public bool canMove;



    private void Update()
    {
        PlayerMovement();
        CalculatePlayerPosWC();
    }

    // Move player based on selected pos 
    void PlayerMovement()
    {


        //// Mehanic for player go back
        //if (backScript.goBack == true)
        //{
        //    pisoarPos.move1 = false;
        //    pisoarPos.move2 = false;
        //    pisoarPos.move3 = false;
        //    pisoarPos.move4 = false;

        //    transform.position = Vector2.MoveTowards(transform.position,
        //    new Vector2(xPos0, yPos0), speed * Time.deltaTime);
        //    canMove = true;
        //}

        // Mehanic for player go on certain pos
        if (canMove == true)
        {

            if (pisoarPos.move1 == true)
            {
                transform.position = Vector2.MoveTowards(transform.position,
                new Vector2(xPos1, yPos1), speed * Time.deltaTime);
                anim.SetBool("Walk", true);


            }

            else if (pisoarPos.move2 == true)
            {
                transform.position = Vector2.MoveTowards(transform.position,
                new Vector2(xPos2, yPos2), speed * Time.deltaTime);
                anim.SetBool("Walk", true);
            }

            else if (pisoarPos.move3 == true)
            {
                transform.position = Vector2.MoveTowards(transform.position,
                new Vector2(xPos3, yPos3), speed * Time.deltaTime);
                anim.SetBool("Walk", true);
            }

            else if (pisoarPos.move4 == true)
            {
                transform.position = Vector2.MoveTowards(transform.position,
                new Vector2(xPos4, yPos4), speed * Time.deltaTime);
                anim.SetBool("Walk", true);
            }
        }
    }

    // **************************************************************************
    // BRANDON IN WC

    // Calculate position for animation, timer, pee
    void CalculatePlayerPosWC()
    {
        if (transform.position.y >= yPosEnd)
        {
            canMove = false;
            anim.SetBool("Walk", false);
            Invoke("CallPeeScene", 2f);
        }
    }

    void CallPeeScene()
    {
        SceneManager.LoadScene(4);
    }
}
