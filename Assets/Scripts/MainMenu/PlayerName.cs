using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
   
    public Text player_name;
    public InputField inputName;

    
    // Update is called once per frame
    void Start()
    {
        //player_name.text = PlayerPrefs.GetString("user_name");
        
    }
    

    public void CreatedName()
    {
        player_name.text = inputName.text;
        //PlayerPrefs.SetString("user_name", player_name.text);
        //PlayerPrefs.Save();
        
    }
}
