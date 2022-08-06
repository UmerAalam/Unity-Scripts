using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetVolume : MonoBehaviour
{
    [SerializeField] AudioSource getVolumeSource;

    void Start()
    {
        getVolumeSource.volume = PlayerPrefs.GetFloat("Volume");
    }
}
