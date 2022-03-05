using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public float maxTime = 3f;
    public float timer = 0;

    public float lifeTime = 0;
    public bool isLive = true;

    public GameObject pipe;
    public float height;

    void Start()
    {
        isLive = true;   
    }

    void Update()
    {

        if (isLive == true)
        {
            lifeTime += Time.deltaTime;
        }
        if (isLive == false)
        {
            lifeTime = 0; 
        }
        if (timer > maxTime&&isLive==true)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(height, -height), 0);
            Destroy(newPipe, 15);
            timer = 0;
        }


        if (lifeTime > 10)
        {
            maxTime = 2.5f;
        }

        if (lifeTime > 20)
        {
            maxTime = 2.1f;
        }

        if (lifeTime > 30)
        {
            maxTime = 1.8f;
        }

        if (lifeTime > 40)
        {
            maxTime = 1.3f;
        }
        if (lifeTime > 55)
        {
            maxTime = 1f;
        }

        timer += Time.deltaTime;
    }
}
