using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if ( other.GetComponent<Player>() != null)
        {
            GameController._instance.Score();
        }
    }
}
