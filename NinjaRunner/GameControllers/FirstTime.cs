using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstTime : MonoBehaviour
{
    [SerializeField] GameObject tipsPanel;
    void Start()
    {
        int hasPlayed = PlayerPrefs.GetInt("HasPlayed");
        if (hasPlayed == 0)
        {

            tipsPanel.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log("HasPlayedNot");
            PlayerPrefs.SetFloat("SpawnRate",0f);
            PlayerPrefs.SetFloat("Volume", 0.3f);
            PlayerPrefs.SetFloat("Effects",1);
            PlayerPrefs.SetFloat("JumpForce",3000f);
            PlayerPrefs.SetFloat("Gravity",3.8f);
            PlayerPrefs.SetFloat("Mass",3.7f);
            PlayerPrefs.SetFloat("ForwardForce",300f);
            PlayerPrefs.SetInt("HasPlayed", 1);
        }
        if (hasPlayed == 1)
        {
             tipsPanel.SetActive(false);
             Debug.Log("HasPlayed");
             PlayerPrefs.SetFloat("SpawnRate", 0f);
             PlayerPrefs.GetFloat("JumpForce");
             PlayerPrefs.GetFloat("Gravity");
             PlayerPrefs.GetFloat("Mass");
             PlayerPrefs.GetFloat("ForwardForce");
        }
    }
}
