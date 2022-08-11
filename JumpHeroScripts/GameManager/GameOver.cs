using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    public static GameOver instance;
    [SerializeField] Text gameOverScoreText;
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] GameObject powerBar;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        gameOverPanel.SetActive(false);
        powerBar.SetActive(true);
    }
    public void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
        powerBar.SetActive(false);
        Animator gameOverAnim = gameOverPanel.GetComponent<Animator>();
        gameOverAnim.Play("Intro");
        gameOverScoreText.text = "" + ScoreManager.instance.GetScore();
        ScoreManager.instance.SetColor();
    }
}
