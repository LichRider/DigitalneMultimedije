using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectedObstacle : MonoBehaviour {

    // Use this for initialization
    public GameManager gameManager;

    void  OnTriggerEnter2D(Collider2D other)
    {
        gameManager.DetectedEnemy();
    }
}
