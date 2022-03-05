using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public GameObject diedGround;
    public GameObject ground;
    public pipeSpawner pipespawner;
    public GameObject pipespawnerObject;

    public GameObject diedCanvas;
    public Text Score;
    public Text dedScore;
    public Text HighestScore;
    public int scoreint=0;

    void Start()
    {
        diedCanvas.SetActive(false);
        Score.text = " "+scoreint;
    }

    // Update is called once per frame
    void Update()
    {

        dedScore.text = ""+scoreint;
        Score.text = "" + scoreint;
    }

    public void isDead()
    {
        diedCanvas.SetActive(true);
        dedScore.text = Score.text;
        pipespawnerObject.SetActive(false);
        Destroy(ground);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("point"))
        {
            scoreint = +scoreint + 50;
                  
        }
      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Tube"))
        {
            isDead();
        }
    }
}
