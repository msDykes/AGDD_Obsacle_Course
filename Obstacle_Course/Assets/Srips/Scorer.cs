using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "hit")
        {
            hits++;
            Debug.Log($"You hit {hits} thing(s).");

        }
        
        
    }
}
