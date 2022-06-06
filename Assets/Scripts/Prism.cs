using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prism : MonoBehaviour
{
    float numberOfHits = 0f;

    public float GetNumberOfHits()
    {
        return numberOfHits;
    }

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        numberOfHits += 0.5f;
    }
}
