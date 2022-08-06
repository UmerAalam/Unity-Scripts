using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitUserInterface : MonoBehaviour
{
    [SerializeField] GameObject quitUI;
    void Start()
    {
        quitUI.SetActive(false);
    }
    
    public void ShowQuitUI()
    {
        quitUI.SetActive(true);
    }
    public void HideQuitUI()
    {
        quitUI.SetActive(false);
    }
}
