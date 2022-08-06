using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sounds : MonoBehaviour
{
    [SerializeField] Toggle effectsToggle;
    [SerializeField] Button jumpBTN;
    [SerializeField] AudioSource soundManager;
    [SerializeField] AudioClip buttonClip;
    [SerializeField] AudioClip jumpClip;
    [SerializeField] AudioClip paperFoldClip;

    private void Start()
    {
        PlayerPrefs.GetFloat("Effects");
        if (PlayerPrefs.GetInt("Toggle") > 0)
            effectsToggle.isOn = true;
        if (PlayerPrefs.GetInt("Toggle") == 0)
            effectsToggle.isOn = false;
        soundManager = GetComponent<AudioSource>();
        jumpBTN = GameObject.Find("JumpButton").GetComponent<Button>();
        jumpBTN.onClick.AddListener(() => PlayJumpClip());
    }

    private void Update()
    {
        CheckToggle();
        if(effectsToggle.isOn == true)
        {
            PlayerPrefs.SetFloat("Effects",1);
            if(PlayerPrefs.GetFloat("Effects") > 0)
            soundManager.volume = PlayerPrefs.GetFloat("Effects",1);
        }
        else if(effectsToggle.isOn == false)
        {
            PlayerPrefs.SetFloat("Effects",0);
            if (PlayerPrefs.GetFloat("Effects") == 0)
                soundManager.volume = PlayerPrefs.GetFloat("Effects",0);
        }
    }
    public void PlayJumpClip()
    {
        soundManager.PlayOneShot(jumpClip,PlayerPrefs.GetFloat("Effects"));
        
    }
    public void PlayButtonClip()
    {
        soundManager.PlayOneShot(buttonClip, PlayerPrefs.GetFloat("Effects"));
    }
    public void PlayPaperFold()
    {
        soundManager.PlayOneShot(paperFoldClip, PlayerPrefs.GetFloat("Effects"));
    }
    void CheckToggle()
    {
        if(effectsToggle.isOn == true)
        {
            PlayerPrefs.SetInt("Toggle",1);
        }
        if(effectsToggle.isOn == false)
        {
            PlayerPrefs.SetInt("Toggle",0);
        }
    }


}
