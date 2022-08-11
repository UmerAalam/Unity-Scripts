using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    [SerializeField] Text scoreText;
    [SerializeField] Color scoreTextColor;
    int score;
    private void Awake()
    {
        scoreTextColor.a = 1f;
        scoreText.color = scoreTextColor;
        score = 0;
        MakeInstance();
    }
    void MakeInstance()
    {
        if (instance == null)
            instance = this;
    }
    public void IncrementScore()
    {
        score++;
        scoreText.text = "" + score;
    }
    public int GetScore()
    {
        return score;
    }
    public void SetColor()
    {
        scoreTextColor.a = 0f;
        scoreText.color = scoreTextColor;
    }
}
