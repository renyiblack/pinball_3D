using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public List<Bouncer> bouncers;
    public List<Prism> prims;
    public List<Bonus> bonuses;
    public GameObject ball;
    public Wall wall;

    int lifes = 3;

    public Hole hole;

    void Start()
    {
    }

    void RemoveBall()
    {
        if (lifes > 0)
        {
            lifes--;
            ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
            ball.transform.position = new Vector3(9.52669f, 1.051738f, -5.470813f);
        }
        else
        {
            Destroy(ball);
        }
    }


    void Update()
    {

        float newScore = 0f;
        foreach (Bouncer item in bouncers)
        {
            newScore += item.GetNumberOfHits();
        }
        foreach (Prism item in prims)
        {
            newScore += item.GetNumberOfHits();
        }
        foreach (Bonus item in bonuses)
        {
            newScore += item.GetNumberOfHits();
        }

        if (hole.GetShouldRemoveBall())
        {
            RemoveBall();
            wall.open();
            hole.reset();
        }

        Score.Instance.UpdateScore(newScore, lifes);
    }
}
