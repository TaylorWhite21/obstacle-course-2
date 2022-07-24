using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int objectsHit = 0;
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "Hit")
        {
            objectsHit++;
            print("You have bumped into an object this many times:" + objectsHit);
        }
    }
}
