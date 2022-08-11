using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController instance;
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
