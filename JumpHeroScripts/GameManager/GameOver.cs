using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static GameOver instance;
    [SerializeField] GameObject gameOverPanel;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        gameOverPanel.SetActive(false);
    }
    public void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
        Animator gameOverAnim = gameOverPanel.GetComponent<Animator>();
        gameOverAnim.Play("Intro");
    }
}
