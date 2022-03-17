using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoBackButton : MonoBehaviour
{
    public bool goBack;

    // Acess other scripts
    [Header("Other scripts store animations")]
    public BrandonAnimations brandonAnim;
    public BillAnimations billAnim;
    public BoJoAnimations bojoAnim;
    public DonaldAnimations donaldAnim;
    public JustinPeeAnimations justinPeeAnim;

    [Header("Enable/Disable Buttons")]

    public GameObject backButton;



    private void Start()
    {
        goBack = false;
    }

    
    public void GoBack()
    {
        goBack = true;       
        ReplaceBtn();  

        //Animations
        brandonAnim.WalkFrontStart();
        billAnim.WalkFrontStart();
        bojoAnim.WalkFrontStart();
        donaldAnim.WalkFrontStart();
        justinPeeAnim.WalkFrontStart();

    }

    void ReplaceBtn()
    {
        backButton.SetActive(false);
    }

    // Button
    public void GoBackBTN()
    {
        GoBack();
    }

    
}

