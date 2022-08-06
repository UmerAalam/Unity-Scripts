using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelUnlocker : MonoBehaviour
{
    [SerializeField] Button stage2;
    [SerializeField] Button stage3;
    int Level2 = PlayerPrefs.GetInt("Level2");
    int Level3 = PlayerPrefs.GetInt("Level3");

    private void Start()
    {
        if(PlayerPrefs.GetInt("Level2") > 0)
        {
        stage2.interactable = true;
        }
        else
        {
        stage2.interactable = false;
        }
        if(PlayerPrefs.GetInt("Level3") > 0)
        {
        stage3.interactable = true;
        }
        else
        {
        stage3.interactable = false;
        }
    }
}
