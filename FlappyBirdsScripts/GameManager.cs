using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject scoreText1;
    public GameObject scoreText2;

    void Start()
    {
        scoreText1.SetActive(true);
        scoreText2.SetActive(false);
        gameOverCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOverScreen()
    {
        scoreText1.SetActive(false);
        scoreText2.SetActive(true);
        gameOverCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
  
}
