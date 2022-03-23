using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CallNextSceneAfterTime : MonoBehaviour
{
    public int callsceneAfterTime;
    public int scene;

    private void Start()
    {
        Invoke("CallScene", callsceneAfterTime);
    }

    void CallScene()
    {
        SceneManager.LoadScene(scene);
    }
}
