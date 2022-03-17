using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonaldAnimations : MonoBehaviour
{
    public Animator anim;


    // Walk
    public void WalkAnimStart()
    {
        anim.SetBool("Walk", true);

    }

    public void WalkAnimStop()
    {
        anim.SetBool("Walk", false);
    }

    public void WalkFrontStart()
    {
        anim.SetBool("WalkFront", true);
    }

    public void WalkFrontStop()
    {
        anim.SetBool("WalkFront", false);
        print("Krenuo je");
    }

    public void LookLeftRight()
    {
        anim.SetBool("LookLeftRight", true);
    }
}
