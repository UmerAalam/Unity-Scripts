using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameplayController : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject physicsPanel;
    [SerializeField] GameObject paueseButton;
    [SerializeField] Button restartButton;
    [SerializeField] Text pauseText;
    public Text scoreText;
    [HideInInspector] public int score;
    float spawnRate;

    void Start()
    {
        spawnRate = 0f;
        scoreText.text = score + "M";
        StartCoroutine(ScoreCount());
    }
    IEnumerator ScoreCount()
    {
        yield return new WaitForSeconds(0.6f);
        score++;
        scoreText.text = score + "M";
        StartCoroutine(ScoreCount());

    }
    private void OnEnable()
    {
        PlayerDied.endGame += PlayerDiedEndTheGame;
    }
    private void OnDisable()
    {
        PlayerDied.endGame -= PlayerDiedEndTheGame;
    }
    void PlayerDiedEndTheGame()
    {
        if (!PlayerPrefs.HasKey("Score"))
        {
            PlayerPrefs.SetInt("Score", 0);
        }
        else
        {
            int highScore = PlayerPrefs.GetInt("Score");
            if (highScore < score)
            {
                PlayerPrefs.SetInt("Score", score);
            }
        }
        pauseText.text = "GameOver";
        pausePanel.SetActive(true);
        restartButton.onClick.RemoveAllListeners();
        restartButton.onClick.AddListener(() => RestartGame());
        Time.timeScale = 0f;
    }
    public  void PauseButton()
    {
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
        restartButton.onClick.RemoveAllListeners();
        restartButton.onClick.AddListener(() => ResumeGame());

    }
    public void GotoMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");

    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
    }
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ShowPhysicsPanel()
    {
        physicsPanel.SetActive(true);
    }
    public void HidePhysicsPanel()
    {
        physicsPanel.SetActive(false);
    }
    private void Update()
    {
        if (pausePanel.activeSelf == true)
        {
            paueseButton.SetActive(false);
        }
        else
        {
            paueseButton.SetActive(true);
        }
        AddSpawnRate();
    }
    void AddSpawnRate()
    {
        if(score >= 50)
        {
            PlayerPrefs.SetFloat("SpawnRate",-3f);
        }
        if (score >= 100)
        {
            PlayerPrefs.SetFloat("SpawnRate",-6f);
        }
        if (score >= 150)
        {
            PlayerPrefs.SetFloat("SpawnRate",-15f);
        }
    }
}
































