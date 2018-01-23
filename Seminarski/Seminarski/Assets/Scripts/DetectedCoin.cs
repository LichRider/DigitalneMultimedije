using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectedCoin : MonoBehaviour
{

    // Use this for initialization
    public GameManager gameManager;

    void OnTriggerEnter2D(Collider2D other)
    {
        gameManager.DetectedCoin();
        GetComponent<Collider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;
    }
}