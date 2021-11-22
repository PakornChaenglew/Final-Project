using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinWhenTouch : MonoBehaviour
{
    public CoinCount coinCountScpt;

    public int x;
    GameManager gameManagerScpt;

    private void Start()
    {
        gameManagerScpt = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        { 
            if(x >= 10)
            {
                gameManagerScpt.WinLevel();
            }
            else
            {
                Debug.Log("Error function");
            }
    }
}
}
