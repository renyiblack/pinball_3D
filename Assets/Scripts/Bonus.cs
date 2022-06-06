using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    float numberOfHits = 0f;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    public float GetNumberOfHits()
    {
        return numberOfHits;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.ToLower().Contains("ball")){
            numberOfHits+=5;
        }
    }
}
