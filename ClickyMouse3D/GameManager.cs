using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI gameOver;
    public TextMeshProUGUI scoreText;
    public GameObject restartButton;
    public GameObject titleScreen;
    public bool isGameActive;
    float spawnRate = 1.0f;
    int score;
    void Start()
    {

    }

    IEnumerator SpawnObjects()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }
   
    public void UpdateScore(int addScore)
    {
        score += addScore;
        scoreText.text = "Score: " + score;
    }
    public void GameOver()
    {
        gameOver.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void StartGame(int difficulty)
    {
        spawnRate /= difficulty;
        isGameActive = true;
        score = 0;
        StartCoroutine(SpawnObjects());
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);

    }
}

