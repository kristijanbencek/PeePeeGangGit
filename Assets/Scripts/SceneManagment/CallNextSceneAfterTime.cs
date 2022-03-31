using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CallNextSceneAfterTime : MonoBehaviour
{
    public float callsceneAfterTime;
    public int scene;

    public Text time;

    private void Start()
    {
        Invoke("CallScene", callsceneAfterTime);
    }

    private void Update()
    {
        callsceneAfterTime -= Time.deltaTime;
        time.text = callsceneAfterTime.ToString("0");
    }

    void CallScene()
    {
        SceneManager.LoadScene(scene);
    }
}
