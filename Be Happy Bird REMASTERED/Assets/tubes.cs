using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tubes : MonoBehaviour

    
{

    public bool isTemas = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isTemas = true;
        }
    }
}
