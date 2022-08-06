using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllers : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void SelectStage()
    {
        SceneManager.LoadScene("SelectStage");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void HighScore()
    {
        SceneManager.LoadScene("HighScore");
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
}
