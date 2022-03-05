using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    public tubes tubes;
    public tubes tubes2;
    void Start()
    {
        speed = 0.6f;
    }

    // Update is called once per frame
    void Update()
    {
        if (tubes.isTemas==true||tubes2.isTemas==true)
        {
            speed = 0;
        }
        transform.position += Vector3.left * speed * Time.deltaTime;
    }


    
}
