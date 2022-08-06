using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    [SerializeField] GameplayController gameplayController;
    public Text highScoreText;
    [HideInInspector] public int highScore;

    private void Start()
    {
        highScoreText.text = "HighScore : " + PlayerPrefs.GetInt("HighScore", 0).ToString();
        gameplayController.scoreText.text = "" + 0;
    }

    private void Update()
    {
        SetHighScore();
    }

    public void SetHighScore()
    {
        highScore = gameplayController.score;
        if(highScore > PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore",highScore);
            highScoreText.text = "HighScore : " + highScore.ToString();
        }
        if(highScore > 200)
        {
            PlayerPrefs.SetInt("Level2",1);
        }
        if(highScore > 400)
        {
            PlayerPrefs.SetInt("Level3",1);
        }
    }

}
