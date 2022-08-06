using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public GameObject sceneLoader;

    public void StartGame()
    {
        SceneManager.LoadScene("Scene_1");
    }
    public void LeaderBoardScene()
    {
        SceneManager.LoadScene("LeaderBoard_Scene");
    }
    public void MenuScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start_Scene");
    }
}
