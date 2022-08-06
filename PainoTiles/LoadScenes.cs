using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    public GameOver retry_Button;
   public void Retry()
   {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main_Scene");
        retry_Button.retryButton.SetActive(false);
   }

}
