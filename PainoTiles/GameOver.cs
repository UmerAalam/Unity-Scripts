using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject retryButton;

    private void Start()
    {
        retryButton.SetActive(false);
    }
    private void OnMouseDown()
    {
        GameOverTime();
    }
   public void GameOverTime()
    {
        retryButton.SetActive(true);
        Time.timeScale = 0;
        Debug.Log("Hello");
    }
}
