using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VolumeController : MonoBehaviour
{
    [SerializeField] AudioSource volumeSource;
    [SerializeField] Slider volumeSlider;
    [HideInInspector] public float setVolume;

    private void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("Volume");
        volumeSource.volume = volumeSlider.value;
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }
    void SetVolume(float volumeValue)
    {
       volumeSource.volume = volumeSlider.value;
        setVolume = volumeSlider.value;
        PlayerPrefs.SetFloat("Volume",setVolume);
        PlayerPrefs.GetFloat("Volume",setVolume);
        volumeSlider.value = PlayerPrefs.GetFloat("Volume",setVolume);
    }
}
