﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour 
{
    public Text scoreText;
    public Text restartText;
    public Text winText;
    public Text loseText;

    int score = 0;
    bool gameEnded = false;

    void Start()
    {
        scoreText.text = "Score: 0";
        restartText.gameObject.SetActive(false);
        winText.gameObject.SetActive(false);
        loseText.gameObject.SetActive(false);

        score = 0;
        gameEnded = false;
    }

    void Update()
    {
        if (score < 0)
            GameOver();

        if (gameEnded)
        {
            if (Input.GetKey(KeyCode.R))
                SceneManager.LoadScene("scene1");
        }
    }

    //---------------------------

    public bool GameEnded
    {
        get{ return gameEnded; }
    }

    public void GameOver()
    {
        gameEnded = true;
        loseText.gameObject.SetActive(true);
        restartText.gameObject.SetActive(true);
    }

    public void Win()
    {
        gameEnded = true;
        winText.gameObject.SetActive(true);
        restartText.gameObject.SetActive(true);
    }

    public void Score(int _score)
    {
        score += _score;
        scoreText.text = "Score: " + score;
    }

}