using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{
    public float distance = 0.9f;
    public float speed = 2.2f;
    public float power = 2000f;
    public float moveCount = 0;

    private Vector3 force = new Vector3();

    private bool resetForce = false;
    private bool applyForce = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.body as Rigidbody)
        {
            if (applyForce)
            {
                (collision.body as Rigidbody).AddForce(force, ForceMode.Acceleration);
            }
            if (resetForce)
            {
                force = new Vector3();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            applyForce = false;
            resetForce = false;
            if (moveCount < distance)
            {
                transform.Translate(0, 0, 0 - speed * Time.deltaTime);
                moveCount += speed * Time.deltaTime;
                force = new Vector3(0, 0, moveCount * power);
            }
        }
        else if (moveCount > 0)
        {
            applyForce = true;
            resetForce = true;
            transform.Translate(0, 0, 0 + speed * Time.deltaTime);
            moveCount -= speed * Time.deltaTime;
        }
    }
}

