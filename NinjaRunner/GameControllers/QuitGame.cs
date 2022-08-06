using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void QuitMyGame()
    {
        Application.Quit();
        Debug.Log("Your Game is Quit Now : Happy!");
    }
}
