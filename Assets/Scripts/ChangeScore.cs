using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;

public class ChangeScore : MonoBehaviour
{
    public static ChangeScore instance;

    private int score = 0;
    public TextMeshProUGUI currentScore;
    public TextMeshProUGUI highScore;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    private void Start()
    {
        currentScore.text = score.ToString();
        highScore.text = PlayerPrefs.GetInt("highscore", 0).ToString();
    }

    private void UpdateHighScore()
    {
        if(score > PlayerPrefs.GetInt("highscore", 0))
        {
            PlayerPrefs.SetInt("highscore", score);
            highScore.text = score.ToString();
        }
    }

    public void changeScore()
    {
        score++;
        currentScore.text = score.ToString();
        UpdateHighScore();
    }
}
