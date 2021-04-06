﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{
    public GameObject ball;
    public Text playerOneText;
    public Text playerTwoText;
    public Transform leftWall;
    public Transform rightWall;

    private int scoreOne = 0;
    private int scoreTwo = 0;
    private Vector2 startPosition = new Vector2(0, 0);

    private void Update()
    {
        ball.GetComponent<Rigidbody2D>().velocity = new Vector2(-1, -1);

        UpdateScore();

        playerOneText.text = scoreOne.ToString();
        playerTwoText.text = scoreTwo.ToString();
    }

    private void UpdateScore()
    {
        if (ball.transform.position.x <= leftWall.position.x)
        {
            scoreTwo++;
            ball.transform.position = startPosition;
        }
        if (ball.transform.position.x >= rightWall.position.x)
        {
            scoreOne++;
            ball.transform.position = startPosition;
        }
    }
}