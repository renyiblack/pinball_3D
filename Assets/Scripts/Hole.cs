using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    bool shouldRemoveBall = false;
    void Start()
    {

    }

    public bool GetShouldRemoveBall()
    {
        return shouldRemoveBall;
    }

    public void reset()
    {
        shouldRemoveBall = false;
    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.ToLower().Contains("ball"))
        {
            // Destroy(collision.gameObject);
            shouldRemoveBall = true;
        }
    }
}
