using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickOnNPC : MonoBehaviour
{
    // GameObjects
    [Header("GameObjects")]

    public GameObject thunderAnim;
    public GameObject player;

    // What happend when click on NPC

    private void OnMouseDown()
    {
        thunderAnim.SetActive(true);
        player.SetActive(false);
        Invoke("CallCurrentScene", 2f);
    }

    void CallCurrentScene()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }
}
