using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score Instance;

    public  TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

     int score = 0;
    int highscore = 0;

    public void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        highscore = PlayerPrefs.GetInt("HighScore", 0);
        scoreText.text = "Score : " + score.ToString();
        highscoreText.text = "Hi-Score : " + highscore.ToString();  
    }

    public void AddPoint()
    {
        score += 10;
        scoreText.text = "Score : " + score.ToString();
        PlayerPrefs.SetInt("Score", score);
        if (highscore < score)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
