using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public int gameCase;

    // Acess other scripts
    [Header("Other scripts")]
    //public GoBackButton backScript;
    public PisoarPosition pisoarPos;
    public PeeButton pee;
    //public Timer timer;

    // Acess other scripts
    [Header("Other scripts store animations")]
    public BrandonAnimations brandonAnim;
    public BillAnimations billAnim;
    public BoJoAnimations bojoAnim;
    public DonaldAnimations donaldAnim;
    public JustinPeeAnimations justinPeeAnim;





    [Header("Player speed")]
    public float speed;


    // GameObjects
    [Header("Game Objects")]
    
    public GameObject backButton;


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


    private void Start()
    {
        canMove = true;
    }

    private void FixedUpdate()
    {
        GameCase();
    }

    public void GameCase()
    {
        switch (gameCase)
        {
            // Wc
            case 0:
                PlayerMovement();
                CalculatePlayerPosWC();
                break;

            // Bar
            case 1:
                PlayerMovement();
                CalculatePlayerPosBar();
                break;

        }
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

                // Animations
                brandonAnim.WalkAnimStart();
                billAnim.WalkAnimStart();
                bojoAnim.WalkAnimStart();
                donaldAnim.WalkAnimStart();
                justinPeeAnim.WalkAnimStart();

            }

            else if (pisoarPos.move2 == true)
            {
                transform.position = Vector2.MoveTowards(transform.position,
                new Vector2(xPos2, yPos2), speed * Time.deltaTime);

                // Animations
                brandonAnim.WalkAnimStart();
                billAnim.WalkAnimStart();
                bojoAnim.WalkAnimStart();
                donaldAnim.WalkAnimStart();
                justinPeeAnim.WalkAnimStart();

            }

            else if (pisoarPos.move3 == true)
            {
                transform.position = Vector2.MoveTowards(transform.position,
                new Vector2(xPos3, yPos3), speed * Time.deltaTime);

                // Animations
                brandonAnim.WalkAnimStart();
                billAnim.WalkAnimStart();
                bojoAnim.WalkAnimStart();
                donaldAnim.WalkAnimStart();
                justinPeeAnim.WalkAnimStart();
            }

            else if (pisoarPos.move4 == true)
            {
                transform.position = Vector2.MoveTowards(transform.position,
                new Vector2(xPos4, yPos4), speed * Time.deltaTime);

                // Animations
                brandonAnim.WalkAnimStart();
                billAnim.WalkAnimStart();
                bojoAnim.WalkAnimStart();
                donaldAnim.WalkAnimStart();
                justinPeeAnim.WalkAnimStart();
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
            pee.PeeStart();
            //backButton.SetActive(true);

            canMove = false;

            // Animations
            brandonAnim.WalkAnimStop();
            billAnim.WalkAnimStop();
            bojoAnim.WalkAnimStop();
            donaldAnim.WalkAnimStop();
            justinPeeAnim.WalkAnimStop();
        }

        else if (transform.position.y <= yPosStart)
        {          
            backButton.SetActive(false);
            //backScript.goBack = false;     

            // Animations
            brandonAnim.WalkFrontStop();
            billAnim.WalkFrontStop();
            bojoAnim.WalkFrontStop();
            donaldAnim.WalkFrontStop();
            justinPeeAnim.WalkFrontStop();
        }
    }



    // **************************************************************************
    // BRANDON IN Bar

    // Calculate position for animation, timer, pee
    void CalculatePlayerPosBar()
    {
        if (transform.position.y >= yPosEnd)
        {
            canMove = false;
            

            //Animations
            brandonAnim.LookLeftRight();
            billAnim.LookLeftRight();
            bojoAnim.LookLeftRight();
            donaldAnim.LookLeftRight();
            justinPeeAnim.LookLeftRight();
        }
    }
}

