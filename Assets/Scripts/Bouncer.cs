using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    public float power = 1000f;

    int numberOfHits = 0;

    void Start()
    {

    }

    public int GetNumberOfHits()
    {
        return numberOfHits;
    }


    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.body as Rigidbody)
        {
            numberOfHits++;
            ContactPoint contact = collision.GetContact(0);
            Vector3 normal = contact.normal;
            (collision.body as Rigidbody).AddForce(new Vector3((normal.x * -1) * power, 0, (normal.z * -1) * power), ForceMode.Acceleration);
        }
    }
}
