using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PeeButton : MonoBehaviour
{
    // Next Scene
    public int scene;

    // Slider
    [Header("Slider")]
    public Image peeSlider;
    public float maxPissLiquid;
    float leftPissLiquid;
   
    // Panels
    [Header("Panels")]
    public GameObject winPanel;

    public Button back;



    // Audio
    [Header("Audio based on time")]
    public AudioSource[] audioSource;
    public AudioClip[] audioClip;

    [Header("Brup")]
    public int playBrupAfterSec;
    bool alreadyPlayedBrup;

    [Header("Relief")]
    public int playReliefAfterSec;
    bool alreadyPlayedRelief;

    [Header("Good Choice")]
    public float playGoodAfterSec;
    bool alreadyPlayedGood;

    [Header("Pee")]
    public GameObject peeSound;





    public void Start()
    {
        leftPissLiquid = maxPissLiquid;
        
    }

 

    public void PeeStart()
    {
        
        if (leftPissLiquid > 0)
        {
            
            leftPissLiquid -= 1 * Time.deltaTime;
            peeSlider.fillAmount = leftPissLiquid / maxPissLiquid;

            if (leftPissLiquid <= 0)
            {
                back.gameObject.SetActive(false);

                winPanel.SetActive(true);
                peeSound.SetActive(false);
                
                Invoke("SceneManagment", 2f);
                ScoreCount.countScore += Timer.timeLeft * 50;
            }

            // Sounds
            GoodChoice();
        }
        
    }

    // Sounds Methods

    void GoodChoice()
    {
        if (leftPissLiquid < playGoodAfterSec)
        {
            if (!alreadyPlayedGood)
            {
                audioSource[2].PlayOneShot(audioClip[2], 1);
                alreadyPlayedGood = true;
            }
        }
    }

    public void SceneManagment()
    {
        SceneManager.LoadScene(scene);
    }


}
