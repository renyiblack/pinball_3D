using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private float currentScore = 0f;
    private int currentLifes = 3;
    public Text scoreText;

    void Start()
    {
        currentScore = 0f;
    }

    public void UpdateScore(float score, int lifes)
    {
        currentScore = score * 10f;
        currentLifes = lifes;
    }

    void Update()
    {
        scoreText.text = "Score: " + currentScore + "\nLifes: " + currentLifes;
    }
}
