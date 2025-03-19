using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameoverScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    int score = 0;
    int highscore = 0;

    void Start()
    {
       highscore = PlayerPrefs.GetInt("HighScore", score);
       score = PlayerPrefs.GetInt("Score",score);
        scoreText.text = "Score : " + score.ToString();
        highscoreText.text = "Hi-Score : " + highscore.ToString();
    }

}
