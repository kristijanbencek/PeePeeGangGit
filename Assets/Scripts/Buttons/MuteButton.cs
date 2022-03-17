using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteButton : MonoBehaviour
{
    public bool mute;
    public bool unmute;

    public GameObject audioObj;

    public GameObject muteIMG;


    private void Start()
    {
        mute = false;
        unmute = true;
        muteIMG.SetActive(false);
    }

    public void MuteUnMute()
    {
        if(mute == false)
        {
            audioObj.SetActive(false);
            unmute = false;
            mute = true;
            muteIMG.SetActive(true);
        }
        else if(unmute == false)
        {
            audioObj.SetActive(true);
            mute = false;
            unmute = true;
            muteIMG.SetActive(false);
        }
    }
}
