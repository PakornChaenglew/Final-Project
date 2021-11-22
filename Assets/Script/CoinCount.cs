using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCount : MonoBehaviour
{
    int scoreCount = 0;
    public TMP_Text scoretext;

    int x;

    public AudioSource source;

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            scoreCount++;
            scoretext.SetText(scoreCount.ToString());
            x = scoreCount;
            source.Play();
        }
    }


}
