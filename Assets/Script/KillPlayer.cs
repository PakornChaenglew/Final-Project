using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{   
    GameManager gameManagerScpt;

    private void Start()
    {
        gameManagerScpt = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(gameManagerScpt.GameOver());
        }
    }
}
