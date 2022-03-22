using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targert : MonoBehaviour
{
    public GameObject target;

    public int targetCounter;

    private void Start()
    {
        targetCounter = GameObject.FindGameObjectsWithTag("Target").Length;


        Invoke("SpawnTarget", 2f);
    }

    public void SpawnTarget()
    {

        float posX = Random.Range(-1.3f, 1.3f);
        float posY = Random.Range(-2.45f, 2.45f);

        Instantiate(target, new Vector2(posX, posY), Quaternion.identity);
    }
}
